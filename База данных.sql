PGDMP  *                    |            NewDecan    16.2    16.2 3               0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    16644    NewDecan    DATABASE     ~   CREATE DATABASE "NewDecan" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';
    DROP DATABASE "NewDecan";
                postgres    false            �            1255    16645    check_group_and_add_student()    FUNCTION     �  CREATE FUNCTION public.check_group_and_add_student() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
    -- Если id_group пустое или NULL, устанавливаем его в "Неизвестно"
    IF NEW.id_group IS NULL OR NEW.id_group = '' THEN
        NEW.id_group = 'Неизвестно';
    END IF;
    
    -- Проверяем существование группы с id_group из NEW
    PERFORM 1 FROM "group" WHERE id_group = NEW.id_group;
    
    -- Если группа существует
    IF FOUND THEN
        -- Проверяем, содержится ли id_student уже в students_ids
        IF array_position(
            (SELECT students_ids FROM "group" WHERE id_group = NEW.id_group),
            NEW.id_student
        ) IS NULL THEN
            -- Добавляем id_student в students_ids в соответствующей группе
            UPDATE "group"
            SET students_ids = array_append(students_ids, NEW.id_student)
            WHERE id_group = NEW.id_group;
        END IF;
    ELSE
        -- Если группа не существует, выбрасываем исключение
        RAISE EXCEPTION 'Группа с id_group % не существует', NEW.id_group;
    END IF;
    
    -- Возвращаем NEW для завершения вставки записи студента
    RETURN NEW;
END;
$$;
 4   DROP FUNCTION public.check_group_and_add_student();
       public          postgres    false            �            1255    16646 !   evaluations_update_subjects_ids()    FUNCTION     �  CREATE FUNCTION public.evaluations_update_subjects_ids() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
declare
subject_id int2;
student_id int4;
BEGIN
    for subject_id in select  unnest(new.subjects_ids)
    loop
	    
    	for student_id in select unnest(new.students_ids)
    	loop
    		if not exists(select 1 from evaluations where id_student=id_student and id_subject=subject_id and semester=current_semester)
    		then 
    			INSERT INTO evaluations (id_student, id_subject, semester)
    			VALUES (student_id, subject_id, current_semester);
    		end if;
    	end loop;
    	
    end loop;
    return new;
END;
$$;
 8   DROP FUNCTION public.evaluations_update_subjects_ids();
       public          postgres    false            �            1255    16647 *   evaluations_update_subjects_students_ids()    FUNCTION     �  CREATE FUNCTION public.evaluations_update_subjects_students_ids() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
declare
subject_id int2;
student_id int4;
current_semester int2;
begin
	current_semester:=NEW.current_semester;
    for subject_id in select  unnest(new.subjects_ids)
    loop
	    
    	for student_id in select unnest(new.students_ids)
    	loop
    		if not exists(select 1 from evaluations where id_student=student_id and id_subject=subject_id and semester=current_semester)
    		then 
    			INSERT INTO evaluations (id_student, id_subject, semester)
    			VALUES (student_id, subject_id, current_semester);
    		end if;
    	end loop;
    	
    end loop;
    return new;
END;
$$;
 A   DROP FUNCTION public.evaluations_update_subjects_students_ids();
       public          postgres    false            �            1255    16648    handle_evaluations_update()    FUNCTION     `  CREATE FUNCTION public.handle_evaluations_update() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
DECLARE
    -- Объявляем переменные для хранения массивов новых студентов и новых предметов
    new_students_ids int4[]; -- Объявляем массив новых студентов
    old_students_ids int4[]; -- Объявляем массив старых студентов
    new_subject_ids int2[]; -- Объявляем массив новых предметов
    old_subject_ids int2[]; -- Объявляем массив старых предметов
    new_students int4[]; -- Массив для хранения новых студентов
    new_subjects int2[]; -- Массив для хранения новых предметов
    student_id int4; -- Переменная для обхода студентов
    subject_id int2; -- Переменная для обхода предметов
BEGIN
    -- Инициализируем массивы студентов и предметов из OLD и NEW записей
    new_students_ids := NEW.students_ids;
    old_students_ids := OLD.students_ids;
    new_subject_ids := NEW.subject_ids;
    old_subject_ids := OLD.subject_ids;

    -- Определяем новые студенты в группе
    SELECT array(SELECT unnest(new_students_ids) EXCEPT SELECT unnest(old_students_ids))
    INTO new_students;
    
    -- Определяем новые предметы в группе
    SELECT array(SELECT unnest(new_subject_ids) EXCEPT SELECT unnest(old_subject_ids))
    INTO new_subjects;
    
    -- Обрабатываем добавление новых студентов
    FOR student_id IN SELECT unnest(new_students)
    LOOP
        FOR subject_id IN SELECT unnest(new_subject_ids)
        LOOP
            -- Проверяем, существует ли запись в evaluations для студента, предмета и семестра
            IF NOT EXISTS (
                SELECT 1
                FROM evaluations
                WHERE id_student = student_id
                AND id_subject = subject_id
                AND semester = NEW.current_semester
            ) THEN
                -- Если запись не существует, создаем новую запись в evaluations
                INSERT INTO evaluations (id_student, id_subject, semester, id_examiner)
                VALUES (student_id, subject_id, NEW.current_semестер, NULL);
            END IF;
        END LOOP;
    END LOOP;
    
    -- Обрабатываем добавление новых предметов
    FOR subject_id IN SELECT unnest(new_subjects)
    LOOP
        FOR student_id IN SELECT unnest(new_students_ids)
        LOOP
            -- Проверяем, существует ли запись в evaluations для студента, предмета и семестра
            IF NOT EXISTS (
                SELECT 1
                FROM evaluations
                WHERE id_student = student_id
                AND id_subject = subject_id
                AND semester = NEW.current_semестер
            ) THEN
                -- Если запись не существует, создаем новую запись в evaluations
                INSERT INTO evaluations (id_student, id_subject, semester, id_examiner)
                VALUES (student_id, subject_id, NEW.current_semестер, NULL);
            END IF;
        END LOOP;
    END LOOP;
    
    RETURN NEW;
END;
$$;
 2   DROP FUNCTION public.handle_evaluations_update();
       public          postgres    false            �            1255    16649    remove_student_from_group()    FUNCTION     �  CREATE FUNCTION public.remove_student_from_group() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
    -- Удаляем id_student из соответствующей группы
    UPDATE "group"
    SET students_ids = array_remove(students_ids, OLD.id_student)
    WHERE id_group = OLD.id_group
    OR id_group = 'Неизвестно';
    
    -- Разрешаем удаление записи студента
    RETURN OLD;
END;
$$;
 2   DROP FUNCTION public.remove_student_from_group();
       public          postgres    false            �            1255    24758    remove_subject_from_groups()    FUNCTION       CREATE FUNCTION public.remove_subject_from_groups() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
    UPDATE "group"
    SET subjects_ids = array_remove(subjects_ids, OLD.id_subject)
    WHERE OLD.id_subject = ANY(subjects_ids);
    RETURN OLD;
END;
$$;
 3   DROP FUNCTION public.remove_subject_from_groups();
       public          postgres    false            �            1255    16650    set_students_to_unknown()    FUNCTION     �  CREATE FUNCTION public.set_students_to_unknown() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
    -- Переводим всех студентов из удаляемой группы в группу "Неизвестно" (NULL)
    UPDATE students
    SET id_group = NULL
    WHERE id_group = OLD.id_group;

    -- Возвращаем старое значение
    RETURN OLD;
END;
$$;
 0   DROP FUNCTION public.set_students_to_unknown();
       public          postgres    false            �            1255    16651    update_student_group()    FUNCTION     �  CREATE FUNCTION public.update_student_group() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
    -- Проверяем существование новой группы
    IF EXISTS (SELECT 1 FROM "group" WHERE id_group = NEW.id_group) then
    	-- Удаление студента в список старой группы
    	UPDATE "group" SET students_ids = array_remove(students_ids, OLD.id_student) WHERE id_group = OLD.id_group;
        -- Добавляем студента в список новой группы
        UPDATE "group" SET students_ids = array_append(students_ids, NEW.id_student) WHERE id_group = NEW.id_group;
        RETURN NEW;
    elseif new.id_group is null or new.id_group = '' then
    	new.id_group:='Неизвестно';
    	-- Удаление студента в список старой группы
    	UPDATE "group" SET students_ids = array_remove(students_ids, OLD.id_student) WHERE id_group = OLD.id_group;
        -- Добавляем студента в список новой группы
        UPDATE "group" SET students_ids = array_append(students_ids, NEW.id_student) WHERE id_group = NEW.id_group;
    	RETURN NEW;
    ELSE
        -- Новая группа не существует, выбрасываем исключение
        RAISE EXCEPTION 'Группа с идентификатором % не существует', NEW.id_group;
    END IF;
END;
$$;
 -   DROP FUNCTION public.update_student_group();
       public          postgres    false            �            1255    16652    update_student_group_ex()    FUNCTION       CREATE FUNCTION public.update_student_group_ex() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
begin 
	update "group" set students_ids=null where id_group=new.id_group;
	update students set id_group =new.id_group where id_group=old.id_group;
	return new;
end;
$$;
 0   DROP FUNCTION public.update_student_group_ex();
       public          postgres    false            �            1259    16653    evaluations    TABLE     �   CREATE TABLE public.evaluations (
    id_student integer NOT NULL,
    id_subject smallint NOT NULL,
    estimation smallint,
    semester smallint NOT NULL,
    id_examiner integer
);
    DROP TABLE public.evaluations;
       public         heap    postgres    false                       0    0    TABLE evaluations    ACL     �   GRANT ALL ON TABLE public.evaluations TO "AlphaTester";
GRANT SELECT ON TABLE public.evaluations TO "Observer";
GRANT SELECT,INSERT,DELETE,UPDATE ON TABLE public.evaluations TO "Employee";
          public          postgres    false    215            �            1259    16656 	   examiners    TABLE     �   CREATE TABLE public.examiners (
    id_examiner integer NOT NULL,
    fullname character varying NOT NULL,
    gender boolean NOT NULL,
    birthday date NOT NULL
);
    DROP TABLE public.examiners;
       public         heap    postgres    false                        0    0    TABLE examiners    ACL     �   GRANT ALL ON TABLE public.examiners TO "AlphaTester";
GRANT SELECT ON TABLE public.examiners TO "Observer";
GRANT SELECT ON TABLE public.examiners TO "Employee";
          public          postgres    false    216            �            1259    16661    examiners_id_examiner_seq    SEQUENCE     �   ALTER TABLE public.examiners ALTER COLUMN id_examiner ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.examiners_id_examiner_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    216            �            1259    16662    group    TABLE     �   CREATE TABLE public."group" (
    id_group character varying NOT NULL,
    num_of_semester smallint NOT NULL,
    students_ids integer[],
    subjects_ids smallint[],
    current_semester smallint NOT NULL
);
    DROP TABLE public."group";
       public         heap    postgres    false            !           0    0    TABLE "group"    ACL     V  GRANT ALL ON TABLE public."group" TO "AlphaTester";
GRANT SELECT,DELETE ON TABLE public."group" TO "Default";
GRANT SELECT ON TABLE public."group" TO "Observer";
GRANT SELECT ON TABLE public."group" TO "MicroObserver";
GRANT SELECT,INSERT,DELETE,UPDATE ON TABLE public."group" TO "Employee";
GRANT ALL ON TABLE public."group" TO "OnlyGroup";
          public          postgres    false    218            �            1259    16667    students    TABLE     �   CREATE TABLE public.students (
    id_student integer NOT NULL,
    gender boolean NOT NULL,
    birthday date NOT NULL,
    fullname character varying NOT NULL,
    id_group character varying NOT NULL
);
    DROP TABLE public.students;
       public         heap    postgres    false            "           0    0    TABLE students    ACL     _  GRANT SELECT,DELETE ON TABLE public.students TO "Default";
GRANT ALL ON TABLE public.students TO "AlphaTester";
GRANT SELECT ON TABLE public.students TO "Observer";
GRANT SELECT ON TABLE public.students TO "MicroObserver";
GRANT SELECT,INSERT,DELETE,UPDATE ON TABLE public.students TO "Employee";
GRANT ALL ON TABLE public.students TO "OnlyStudents";
          public          postgres    false    219            �            1259    16672    students_id_student_seq    SEQUENCE     �   ALTER TABLE public.students ALTER COLUMN id_student ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.students_id_student_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    219            �            1259    16673    subjects    TABLE     h   CREATE TABLE public.subjects (
    id_subject smallint NOT NULL,
    name character varying NOT NULL
);
    DROP TABLE public.subjects;
       public         heap    postgres    false            #           0    0    TABLE subjects    ACL     �   GRANT ALL ON TABLE public.subjects TO "AlphaTester";
GRANT SELECT ON TABLE public.subjects TO "Observer";
GRANT SELECT ON TABLE public.subjects TO "Employee";
          public          postgres    false    221            �            1259    16678    subjects_id_subject_seq    SEQUENCE     �   ALTER TABLE public.subjects ALTER COLUMN id_subject ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.subjects_id_subject_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    221                      0    16653    evaluations 
   TABLE DATA           `   COPY public.evaluations (id_student, id_subject, estimation, semester, id_examiner) FROM stdin;
    public          postgres    false    215   la                 0    16656 	   examiners 
   TABLE DATA           L   COPY public.examiners (id_examiner, fullname, gender, birthday) FROM stdin;
    public          postgres    false    216   �a                 0    16662    group 
   TABLE DATA           j   COPY public."group" (id_group, num_of_semester, students_ids, subjects_ids, current_semester) FROM stdin;
    public          postgres    false    218   :b                 0    16667    students 
   TABLE DATA           T   COPY public.students (id_student, gender, birthday, fullname, id_group) FROM stdin;
    public          postgres    false    219   �b                 0    16673    subjects 
   TABLE DATA           4   COPY public.subjects (id_subject, name) FROM stdin;
    public          postgres    false    221   �c       $           0    0    examiners_id_examiner_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public.examiners_id_examiner_seq', 6, true);
          public          postgres    false    217            %           0    0    students_id_student_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.students_id_student_seq', 51, true);
          public          postgres    false    220            &           0    0    subjects_id_subject_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.subjects_id_subject_seq', 13, true);
          public          postgres    false    222            l           2606    24668    evaluations evaluations_unique 
   CONSTRAINT     �   ALTER TABLE ONLY public.evaluations
    ADD CONSTRAINT evaluations_unique UNIQUE (id_student, id_subject, semester, id_examiner);
 H   ALTER TABLE ONLY public.evaluations DROP CONSTRAINT evaluations_unique;
       public            postgres    false    215    215    215    215            n           2606    16680    examiners examiners_pk 
   CONSTRAINT     ]   ALTER TABLE ONLY public.examiners
    ADD CONSTRAINT examiners_pk PRIMARY KEY (id_examiner);
 @   ALTER TABLE ONLY public.examiners DROP CONSTRAINT examiners_pk;
       public            postgres    false    216            p           2606    16684    group group_pk 
   CONSTRAINT     T   ALTER TABLE ONLY public."group"
    ADD CONSTRAINT group_pk PRIMARY KEY (id_group);
 :   ALTER TABLE ONLY public."group" DROP CONSTRAINT group_pk;
       public            postgres    false    218            r           2606    16688    students students_pk 
   CONSTRAINT     Z   ALTER TABLE ONLY public.students
    ADD CONSTRAINT students_pk PRIMARY KEY (id_student);
 >   ALTER TABLE ONLY public.students DROP CONSTRAINT students_pk;
       public            postgres    false    219            t           2606    16690    subjects subjects_pk 
   CONSTRAINT     Z   ALTER TABLE ONLY public.subjects
    ADD CONSTRAINT subjects_pk PRIMARY KEY (id_subject);
 >   ALTER TABLE ONLY public.subjects DROP CONSTRAINT subjects_pk;
       public            postgres    false    221            v           2606    24636    subjects subjects_unique 
   CONSTRAINT     S   ALTER TABLE ONLY public.subjects
    ADD CONSTRAINT subjects_unique UNIQUE (name);
 B   ALTER TABLE ONLY public.subjects DROP CONSTRAINT subjects_unique;
       public            postgres    false    221            z           2620    16693 $   group before_delete_group_trigger_ex    TRIGGER     �   CREATE TRIGGER before_delete_group_trigger_ex AFTER DELETE ON public."group" FOR EACH ROW EXECUTE FUNCTION public.set_students_to_unknown();
 ?   DROP TRIGGER before_delete_group_trigger_ex ON public."group";
       public          postgres    false    218    229            ~           2620    16694    students check_group_trigger    TRIGGER     �   CREATE TRIGGER check_group_trigger BEFORE INSERT ON public.students FOR EACH ROW EXECUTE FUNCTION public.check_group_and_add_student();
 5   DROP TRIGGER check_group_trigger ON public.students;
       public          postgres    false    219    223            {           2620    16695 -   group evaluations_update_trigger_students_ids    TRIGGER       CREATE TRIGGER evaluations_update_trigger_students_ids AFTER UPDATE OF students_ids ON public."group" FOR EACH ROW EXECUTE FUNCTION public.evaluations_update_subjects_students_ids();

ALTER TABLE public."group" DISABLE TRIGGER evaluations_update_trigger_students_ids;
 H   DROP TRIGGER evaluations_update_trigger_students_ids ON public."group";
       public          postgres    false    218    218    226            |           2620    16696 -   group evaluations_update_trigger_subjects_ids    TRIGGER     �   CREATE TRIGGER evaluations_update_trigger_subjects_ids AFTER UPDATE OF subjects_ids ON public."group" FOR EACH ROW EXECUTE FUNCTION public.evaluations_update_subjects_students_ids();
 H   DROP TRIGGER evaluations_update_trigger_subjects_ids ON public."group";
       public          postgres    false    218    226    218                       2620    16697 *   students remove_student_from_group_trigger    TRIGGER     �   CREATE TRIGGER remove_student_from_group_trigger BEFORE DELETE ON public.students FOR EACH ROW EXECUTE FUNCTION public.remove_student_from_group();
 C   DROP TRIGGER remove_student_from_group_trigger ON public.students;
       public          postgres    false    228    219            �           2620    24759    subjects remove_subject_trigger    TRIGGER     �   CREATE TRIGGER remove_subject_trigger BEFORE DELETE ON public.subjects FOR EACH ROW EXECUTE FUNCTION public.remove_subject_from_groups();
 8   DROP TRIGGER remove_subject_trigger ON public.subjects;
       public          postgres    false    221    225            �           2620    16698 %   students update_student_group_trigger    TRIGGER     �   CREATE TRIGGER update_student_group_trigger BEFORE UPDATE ON public.students FOR EACH ROW EXECUTE FUNCTION public.update_student_group();
 >   DROP TRIGGER update_student_group_trigger ON public.students;
       public          postgres    false    241    219            }           2620    16699 #   group update_students_group_trigger    TRIGGER     �   CREATE TRIGGER update_students_group_trigger AFTER UPDATE OF id_group ON public."group" FOR EACH ROW EXECUTE FUNCTION public.update_student_group_ex();
 >   DROP TRIGGER update_students_group_trigger ON public."group";
       public          postgres    false    218    242    218            w           2606    24747    evaluations fk_examiner    FK CONSTRAINT     �   ALTER TABLE ONLY public.evaluations
    ADD CONSTRAINT fk_examiner FOREIGN KEY (id_examiner) REFERENCES public.examiners(id_examiner) ON UPDATE SET NULL ON DELETE SET NULL;
 A   ALTER TABLE ONLY public.evaluations DROP CONSTRAINT fk_examiner;
       public          postgres    false    216    215    4718            x           2606    16705    evaluations fk_student    FK CONSTRAINT     �   ALTER TABLE ONLY public.evaluations
    ADD CONSTRAINT fk_student FOREIGN KEY (id_student) REFERENCES public.students(id_student) ON UPDATE CASCADE ON DELETE CASCADE;
 @   ALTER TABLE ONLY public.evaluations DROP CONSTRAINT fk_student;
       public          postgres    false    215    4722    219            y           2606    24742    evaluations fk_subject    FK CONSTRAINT     �   ALTER TABLE ONLY public.evaluations
    ADD CONSTRAINT fk_subject FOREIGN KEY (id_subject) REFERENCES public.subjects(id_subject) ON UPDATE CASCADE ON DELETE CASCADE;
 @   ALTER TABLE ONLY public.evaluations DROP CONSTRAINT fk_subject;
       public          postgres    false    221    4724    215               8   x�32�4���4\�H#d�9��2de�	H�)�mRdd��c���� ��         v   x�e̱!@��g
� �%�b��66��X[�rgx�Fr��/��R�P��@��ֽ�O|xR�dy�B���uZ����f�T=�"[��.�/�ݵ9���Β,[�>&���,�1_HK�         ]   x�%��� F��,`j��0nB8��&D/:��F���VU�XG����r*�*N�Q��\�I(�F!a��Z}C�Ɖ�d��y4�c��� �         �   x�m�=�0����@���r�^���ZX�	!�1��(-�����`I,��{�A_�8,���#����*E;J��[*��r�_L̊�怒���(mh9�Wc hOu�,͊�f��;����/��i,`��5;gT���{G���K��]O[��&*��q�р��}'>+6<�QN7Ff&1�/]�S5���x�V�E%�棁��	���         D   x�3�0�b�Ŧ��]�ě/���e�yaH��>�H����[/��;.캰�+F��� �a(u     