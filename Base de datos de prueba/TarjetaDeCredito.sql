PGDMP                         {            TarjetaDeCredito    15.3    15.3 �    .           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            /           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            0           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            1           1262    16888    TarjetaDeCredito    DATABASE     �   CREATE DATABASE "TarjetaDeCredito" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Spanish_Honduras.1252';
 "   DROP DATABASE "TarjetaDeCredito";
                postgres    false            �            1259    17379    Estatus    TABLE     \   CREATE TABLE public."Estatus" (
    "Estatus_id" integer NOT NULL,
    "Estatus" boolean
);
    DROP TABLE public."Estatus";
       public         heap    postgres    false            �            1259    16928    ciudad    TABLE     �   CREATE TABLE public.ciudad (
    ciudad_id bigint NOT NULL,
    municipio_id integer NOT NULL,
    nombre_ciudad character varying(50) NOT NULL
);
    DROP TABLE public.ciudad;
       public         heap    postgres    false            �            1259    17150    cliente    TABLE     �   CREATE TABLE public.cliente (
    cliente_id integer NOT NULL,
    persona_id character varying,
    datos_laborales_id integer NOT NULL
);
    DROP TABLE public.cliente;
       public         heap    postgres    false            �            1259    17374    comite    TABLE     f   CREATE TABLE public.comite (
    comite_id integer NOT NULL,
    descripcion character varying(50)
);
    DROP TABLE public.comite;
       public         heap    postgres    false            �            1259    17455    comitexempleado    TABLE     X   CREATE TABLE public.comitexempleado (
    empleado_id integer,
    comite_id integer
);
 #   DROP TABLE public.comitexempleado;
       public         heap    postgres    false            �            1259    17249    compania_tarjeta    TABLE     �   CREATE TABLE public.compania_tarjeta (
    compania_id integer NOT NULL,
    nombre character varying(100) NOT NULL,
    cargo_de_compra numeric(10,2) NOT NULL
);
 $   DROP TABLE public.compania_tarjeta;
       public         heap    postgres    false            �            1259    17254    cuenta    TABLE     �   CREATE TABLE public.cuenta (
    cuenta_id integer NOT NULL,
    num_cuenta character(10) NOT NULL,
    saldo numeric(10,2) NOT NULL,
    cliente_id integer NOT NULL
);
    DROP TABLE public.cuenta;
       public         heap    postgres    false            �            1259    17024    datos_laborales    TABLE     �   CREATE TABLE public.datos_laborales (
    ingreso_mensual numeric(10,2),
    ocupacion_id integer NOT NULL,
    "Fecha_ingreo" date,
    cargo character varying(50),
    datos_laborales_id bigint NOT NULL
);
 #   DROP TABLE public.datos_laborales;
       public         heap    postgres    false            �            1259    17034 &   datos_laborales_datos_laborales_id_seq    SEQUENCE     �   CREATE SEQUENCE public.datos_laborales_datos_laborales_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 =   DROP SEQUENCE public.datos_laborales_datos_laborales_id_seq;
       public          postgres    false    223            2           0    0 &   datos_laborales_datos_laborales_id_seq    SEQUENCE OWNED BY     q   ALTER SEQUENCE public.datos_laborales_datos_laborales_id_seq OWNED BY public.datos_laborales.datos_laborales_id;
          public          postgres    false    224            �            1259    16896    departamento    TABLE     �   CREATE TABLE public.departamento (
    departamento_id integer NOT NULL,
    nombre_depto character varying(50) NOT NULL,
    zona character varying(50),
    pais_id integer NOT NULL
);
     DROP TABLE public.departamento;
       public         heap    postgres    false            �            1259    17199    departamento_banco    TABLE     �   CREATE TABLE public.departamento_banco (
    departamento_bancoid integer NOT NULL,
    nombre character varying(50),
    descripcion character varying(100)
);
 &   DROP TABLE public.departamento_banco;
       public         heap    postgres    false            �            1259    16938 	   direccion    TABLE     _  CREATE TABLE public.direccion (
    departamentoid integer NOT NULL,
    cuidadid bigint NOT NULL,
    municipioid integer NOT NULL,
    calle character varying(50),
    avenida character varying(50),
    referencia_geografica character varying(50),
    numero_casa_apartameto integer,
    paisid integer NOT NULL,
    direccion_id bigint NOT NULL
);
    DROP TABLE public.direccion;
       public         heap    postgres    false            �            1259    16963    direccion_direccion_id_seq    SEQUENCE     �   CREATE SEQUENCE public.direccion_direccion_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public.direccion_direccion_id_seq;
       public          postgres    false    218            3           0    0    direccion_direccion_id_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public.direccion_direccion_id_seq OWNED BY public.direccion.direccion_id;
          public          postgres    false    219            �            1259    17223    empleado    TABLE       CREATE TABLE public.empleado (
    empleado_id integer NOT NULL,
    puesto_id integer NOT NULL,
    departamento_bancoid integer NOT NULL,
    sucursal_id integer NOT NULL,
    persona_id character varying NOT NULL,
    correo_corporativo character varying(100) NOT NULL
);
    DROP TABLE public.empleado;
       public         heap    postgres    false            �            1259    17484    estado    TABLE     e   CREATE TABLE public.estado (
    estadoid integer NOT NULL,
    descripcion character varying(15)
);
    DROP TABLE public.estado;
       public         heap    postgres    false            �            1259    17305    estado_cuenta    TABLE     �  CREATE TABLE public.estado_cuenta (
    estado_cuenta_id integer NOT NULL,
    num_cuenta character(10) NOT NULL,
    cliente_id integer NOT NULL,
    cuenta_id integer NOT NULL,
    pago_minimo numeric(10,2),
    pago_total numeric(10,2),
    plazo_meses integer,
    puntos_totales integer,
    puntos_obtenidos integer,
    limite_credito numeric(10,2) NOT NULL,
    credito_disponible numeric(10,2) NOT NULL,
    fecha_maxima_pago date,
    fecha_corte date
);
 !   DROP TABLE public.estado_cuenta;
       public         heap    postgres    false            �            1259    17489    estado_solicitud    TABLE     �   CREATE TABLE public.estado_solicitud (
    estado_solicitudid integer NOT NULL,
    estadoid integer,
    descripcion character varying(100),
    fecha date,
    comite_id integer
);
 $   DROP TABLE public.estado_solicitud;
       public         heap    postgres    false            �            1259    17364    extrafinanciamiento    TABLE     �   CREATE TABLE public.extrafinanciamiento (
    extrafinanciamiento_id integer NOT NULL,
    interes_anual double precision,
    interes_mensual double precision,
    pago_total double precision,
    pago_mensual double precision,
    tarjeta_id integer
);
 '   DROP TABLE public.extrafinanciamiento;
       public         heap    postgres    false            �            1259    17354    historial_transacciones    TABLE     L  CREATE TABLE public.historial_transacciones (
    historial_transaccionesid integer NOT NULL,
    debito_compra numeric(10,2),
    credito_compra numeric(10,2),
    limite_integrado numeric(10,2) NOT NULL,
    credito_disponible numeric(10,2) NOT NULL,
    descripcion character varying(100),
    transaccion_id integer NOT NULL
);
 +   DROP TABLE public.historial_transacciones;
       public         heap    postgres    false            �            1259    17439    mora    TABLE     �   CREATE TABLE public.mora (
    moraid integer NOT NULL,
    fecha date,
    meses integer,
    monto_adecuado numeric(10,2),
    cliente_id integer,
    estatusid integer,
    CONSTRAINT checkmora CHECK ((meses <= 12))
);
    DROP TABLE public.mora;
       public         heap    postgres    false            �            1259    16906 	   municipio    TABLE     �   CREATE TABLE public.municipio (
    municipio_id bigint NOT NULL,
    nombre_municipio character varying(50) NOT NULL,
    departamento_id integer NOT NULL
);
    DROP TABLE public.municipio;
       public         heap    postgres    false            �            1259    17017 	   ocupacion    TABLE     p   CREATE TABLE public.ocupacion (
    ocupacion_id integer NOT NULL,
    titulo character varying(50) NOT NULL
);
    DROP TABLE public.ocupacion;
       public         heap    postgres    false            �            1259    17581    pago_credito    TABLE     �   CREATE TABLE public.pago_credito (
    pago_creditoid integer NOT NULL,
    fecha date,
    hora time without time zone,
    pago numeric(10,2),
    cliente_id integer
);
     DROP TABLE public.pago_credito;
       public         heap    postgres    false            �            1259    16889    pais    TABLE     k   CREATE TABLE public.pais (
    pais_id integer NOT NULL,
    nombre_pais character varying(50) NOT NULL
);
    DROP TABLE public.pais;
       public         heap    postgres    false            �            1259    17063    persona    TABLE     �  CREATE TABLE public.persona (
    persona_id character varying(20) NOT NULL,
    p_nombre character varying(30) NOT NULL,
    s_nombre character varying(30),
    p_apellido character varying(30) NOT NULL,
    s_apellido character varying(30),
    correo character varying(50),
    fecha_nacimiento date,
    direccion_id integer NOT NULL,
    tipo_personaid integer NOT NULL,
    tipo_documentoid integer NOT NULL
);
    DROP TABLE public.persona;
       public         heap    postgres    false            �            1259    17172    puesto    TABLE     h   CREATE TABLE public.puesto (
    puesto_id integer NOT NULL,
    nombre_puesto character varying(50)
);
    DROP TABLE public.puesto;
       public         heap    postgres    false            �            1259    17468    quejas    TABLE     �   CREATE TABLE public.quejas (
    quejas_id integer NOT NULL,
    descripcion character varying(100),
    fecha date,
    cliente_id integer,
    empleado_id integer
);
    DROP TABLE public.quejas;
       public         heap    postgres    false            �            1259    17554    referencia_personal    TABLE     r   CREATE TABLE public.referencia_personal (
    persona_id character varying,
    referencia_id integer NOT NULL
);
 '   DROP TABLE public.referencia_personal;
       public         heap    postgres    false            �            1259    17504    solicitud_tarjeta    TABLE     !  CREATE TABLE public.solicitud_tarjeta (
    solicitud_id integer NOT NULL,
    persona_id character varying NOT NULL,
    direccion_id integer NOT NULL,
    sucursal_id integer NOT NULL,
    tarjeta_id integer NOT NULL,
    fecha_solicitud date,
    estado_solicitudid integer NOT NULL
);
 %   DROP TABLE public.solicitud_tarjeta;
       public         heap    postgres    false            �            1259    17177    sucursal    TABLE     �   CREATE TABLE public.sucursal (
    sucursal_id integer NOT NULL,
    direccion_id integer,
    nombre_sucursal character varying(50)
);
    DROP TABLE public.sucursal;
       public         heap    postgres    false            �            1259    17278    tarjeta    TABLE     �  CREATE TABLE public.tarjeta (
    tarjeta_id integer NOT NULL,
    pin character(4) NOT NULL,
    cvc character(3) NOT NULL,
    numero_tarjeta character(16) NOT NULL,
    fecha_emision date,
    fecha_vencimiento date,
    costo_membresia double precision NOT NULL,
    interes_anual double precision NOT NULL,
    interes_mensual double precision NOT NULL,
    compania_id integer NOT NULL,
    cliente_id integer NOT NULL,
    sucursal_id integer NOT NULL,
    cuentaid integer NOT NULL
);
    DROP TABLE public.tarjeta;
       public         heap    postgres    false            �            1259    17128    telefono    TABLE     �   CREATE TABLE public.telefono (
    num_telefono character(8) NOT NULL,
    persona_id character varying NOT NULL,
    "TelefonoID" bigint NOT NULL,
    pais_id integer NOT NULL
);
    DROP TABLE public.telefono;
       public         heap    postgres    false            �            1259    17140    telefono_TelefonoID_seq    SEQUENCE     �   CREATE SEQUENCE public."telefono_TelefonoID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 0   DROP SEQUENCE public."telefono_TelefonoID_seq";
       public          postgres    false    226            4           0    0    telefono_TelefonoID_seq    SEQUENCE OWNED BY     W   ALTER SEQUENCE public."telefono_TelefonoID_seq" OWNED BY public.telefono."TelefonoID";
          public          postgres    false    227            �            1259    17187    telefonosucursal    TABLE     �   CREATE TABLE public.telefonosucursal (
    telefonoid integer NOT NULL,
    num_telefono character(8) NOT NULL,
    sucursal_id integer NOT NULL
);
 $   DROP TABLE public.telefonosucursal;
       public         heap    postgres    false            �            1259    17012    tipo_documento    TABLE     y   CREATE TABLE public.tipo_documento (
    tipo_documentoid integer NOT NULL,
    nombre character varying(50) NOT NULL
);
 "   DROP TABLE public.tipo_documento;
       public         heap    postgres    false            �            1259    17007    tipo_persona    TABLE     i   CREATE TABLE public.tipo_persona (
    tipo_personaid integer NOT NULL,
    descripcion character(50)
);
     DROP TABLE public.tipo_persona;
       public         heap    postgres    false            �            1259    17320    tipo_transaccion    TABLE     t   CREATE TABLE public.tipo_transaccion (
    tipo_transaccionid integer NOT NULL,
    nombre character varying(50)
);
 $   DROP TABLE public.tipo_transaccion;
       public         heap    postgres    false            �            1259    17325    transacciones    TABLE     +  CREATE TABLE public.transacciones (
    transaccionesid integer NOT NULL,
    tipo_transaccionid integer,
    cantidad_transaccion numeric(10,2),
    fecha_transaccion date,
    hora time without time zone,
    establecimiento character varying(100),
    ciudad_id bigint,
    tarjeta_id integer
);
 !   DROP TABLE public.transacciones;
       public         heap    postgres    false            �           2604    17035 "   datos_laborales datos_laborales_id    DEFAULT     �   ALTER TABLE ONLY public.datos_laborales ALTER COLUMN datos_laborales_id SET DEFAULT nextval('public.datos_laborales_datos_laborales_id_seq'::regclass);
 Q   ALTER TABLE public.datos_laborales ALTER COLUMN datos_laborales_id DROP DEFAULT;
       public          postgres    false    224    223            �           2604    16964    direccion direccion_id    DEFAULT     �   ALTER TABLE ONLY public.direccion ALTER COLUMN direccion_id SET DEFAULT nextval('public.direccion_direccion_id_seq'::regclass);
 E   ALTER TABLE public.direccion ALTER COLUMN direccion_id DROP DEFAULT;
       public          postgres    false    219    218            �           2604    17141    telefono TelefonoID    DEFAULT     ~   ALTER TABLE ONLY public.telefono ALTER COLUMN "TelefonoID" SET DEFAULT nextval('public."telefono_TelefonoID_seq"'::regclass);
 D   ALTER TABLE public.telefono ALTER COLUMN "TelefonoID" DROP DEFAULT;
       public          postgres    false    227    226            #          0    17379    Estatus 
   TABLE DATA           <   COPY public."Estatus" ("Estatus_id", "Estatus") FROM stdin;
    public          postgres    false    243   ��       	          0    16928    ciudad 
   TABLE DATA           H   COPY public.ciudad (ciudad_id, municipio_id, nombre_ciudad) FROM stdin;
    public          postgres    false    217   ��                 0    17150    cliente 
   TABLE DATA           M   COPY public.cliente (cliente_id, persona_id, datos_laborales_id) FROM stdin;
    public          postgres    false    228   \�       "          0    17374    comite 
   TABLE DATA           8   COPY public.comite (comite_id, descripcion) FROM stdin;
    public          postgres    false    242   ��       %          0    17455    comitexempleado 
   TABLE DATA           A   COPY public.comitexempleado (empleado_id, comite_id) FROM stdin;
    public          postgres    false    245   ��                 0    17249    compania_tarjeta 
   TABLE DATA           P   COPY public.compania_tarjeta (compania_id, nombre, cargo_de_compra) FROM stdin;
    public          postgres    false    234   ��                 0    17254    cuenta 
   TABLE DATA           J   COPY public.cuenta (cuenta_id, num_cuenta, saldo, cliente_id) FROM stdin;
    public          postgres    false    235   �                 0    17024    datos_laborales 
   TABLE DATA           s   COPY public.datos_laborales (ingreso_mensual, ocupacion_id, "Fecha_ingreo", cargo, datos_laborales_id) FROM stdin;
    public          postgres    false    223   6�                 0    16896    departamento 
   TABLE DATA           T   COPY public.departamento (departamento_id, nombre_depto, zona, pais_id) FROM stdin;
    public          postgres    false    215   z�                 0    17199    departamento_banco 
   TABLE DATA           W   COPY public.departamento_banco (departamento_bancoid, nombre, descripcion) FROM stdin;
    public          postgres    false    232   ��       
          0    16938 	   direccion 
   TABLE DATA           �   COPY public.direccion (departamentoid, cuidadid, municipioid, calle, avenida, referencia_geografica, numero_casa_apartameto, paisid, direccion_id) FROM stdin;
    public          postgres    false    218   f�                 0    17223    empleado 
   TABLE DATA           }   COPY public.empleado (empleado_id, puesto_id, departamento_bancoid, sucursal_id, persona_id, correo_corporativo) FROM stdin;
    public          postgres    false    233   ��       '          0    17484    estado 
   TABLE DATA           7   COPY public.estado (estadoid, descripcion) FROM stdin;
    public          postgres    false    247   9�                 0    17305    estado_cuenta 
   TABLE DATA           �   COPY public.estado_cuenta (estado_cuenta_id, num_cuenta, cliente_id, cuenta_id, pago_minimo, pago_total, plazo_meses, puntos_totales, puntos_obtenidos, limite_credito, credito_disponible, fecha_maxima_pago, fecha_corte) FROM stdin;
    public          postgres    false    237   y�       (          0    17489    estado_solicitud 
   TABLE DATA           g   COPY public.estado_solicitud (estado_solicitudid, estadoid, descripcion, fecha, comite_id) FROM stdin;
    public          postgres    false    248   ��       !          0    17364    extrafinanciamiento 
   TABLE DATA           �   COPY public.extrafinanciamiento (extrafinanciamiento_id, interes_anual, interes_mensual, pago_total, pago_mensual, tarjeta_id) FROM stdin;
    public          postgres    false    241   �                  0    17354    historial_transacciones 
   TABLE DATA           �   COPY public.historial_transacciones (historial_transaccionesid, debito_compra, credito_compra, limite_integrado, credito_disponible, descripcion, transaccion_id) FROM stdin;
    public          postgres    false    240   5�       $          0    17439    mora 
   TABLE DATA           [   COPY public.mora (moraid, fecha, meses, monto_adecuado, cliente_id, estatusid) FROM stdin;
    public          postgres    false    244   k�                 0    16906 	   municipio 
   TABLE DATA           T   COPY public.municipio (municipio_id, nombre_municipio, departamento_id) FROM stdin;
    public          postgres    false    216   ��                 0    17017 	   ocupacion 
   TABLE DATA           9   COPY public.ocupacion (ocupacion_id, titulo) FROM stdin;
    public          postgres    false    222   �       +          0    17581    pago_credito 
   TABLE DATA           U   COPY public.pago_credito (pago_creditoid, fecha, hora, pago, cliente_id) FROM stdin;
    public          postgres    false    251   ��                 0    16889    pais 
   TABLE DATA           4   COPY public.pais (pais_id, nombre_pais) FROM stdin;
    public          postgres    false    214   ��                 0    17063    persona 
   TABLE DATA           �   COPY public.persona (persona_id, p_nombre, s_nombre, p_apellido, s_apellido, correo, fecha_nacimiento, direccion_id, tipo_personaid, tipo_documentoid) FROM stdin;
    public          postgres    false    225   �                 0    17172    puesto 
   TABLE DATA           :   COPY public.puesto (puesto_id, nombre_puesto) FROM stdin;
    public          postgres    false    229   ��       &          0    17468    quejas 
   TABLE DATA           X   COPY public.quejas (quejas_id, descripcion, fecha, cliente_id, empleado_id) FROM stdin;
    public          postgres    false    246   ��       *          0    17554    referencia_personal 
   TABLE DATA           H   COPY public.referencia_personal (persona_id, referencia_id) FROM stdin;
    public          postgres    false    250   3�       )          0    17504    solicitud_tarjeta 
   TABLE DATA           �   COPY public.solicitud_tarjeta (solicitud_id, persona_id, direccion_id, sucursal_id, tarjeta_id, fecha_solicitud, estado_solicitudid) FROM stdin;
    public          postgres    false    249   `�                 0    17177    sucursal 
   TABLE DATA           N   COPY public.sucursal (sucursal_id, direccion_id, nombre_sucursal) FROM stdin;
    public          postgres    false    230   ��                 0    17278    tarjeta 
   TABLE DATA           �   COPY public.tarjeta (tarjeta_id, pin, cvc, numero_tarjeta, fecha_emision, fecha_vencimiento, costo_membresia, interes_anual, interes_mensual, compania_id, cliente_id, sucursal_id, cuentaid) FROM stdin;
    public          postgres    false    236   ��                 0    17128    telefono 
   TABLE DATA           S   COPY public.telefono (num_telefono, persona_id, "TelefonoID", pais_id) FROM stdin;
    public          postgres    false    226   �                 0    17187    telefonosucursal 
   TABLE DATA           Q   COPY public.telefonosucursal (telefonoid, num_telefono, sucursal_id) FROM stdin;
    public          postgres    false    231   G�                 0    17012    tipo_documento 
   TABLE DATA           B   COPY public.tipo_documento (tipo_documentoid, nombre) FROM stdin;
    public          postgres    false    221   n�                 0    17007    tipo_persona 
   TABLE DATA           C   COPY public.tipo_persona (tipo_personaid, descripcion) FROM stdin;
    public          postgres    false    220   ��                 0    17320    tipo_transaccion 
   TABLE DATA           F   COPY public.tipo_transaccion (tipo_transaccionid, nombre) FROM stdin;
    public          postgres    false    238   ��                 0    17325    transacciones 
   TABLE DATA           �   COPY public.transacciones (transaccionesid, tipo_transaccionid, cantidad_transaccion, fecha_transaccion, hora, establecimiento, ciudad_id, tarjeta_id) FROM stdin;
    public          postgres    false    239   �       5           0    0 &   datos_laborales_datos_laborales_id_seq    SEQUENCE SET     T   SELECT pg_catalog.setval('public.datos_laborales_datos_laborales_id_seq', 1, true);
          public          postgres    false    224            6           0    0    direccion_direccion_id_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public.direccion_direccion_id_seq', 2, true);
          public          postgres    false    219            7           0    0    telefono_TelefonoID_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public."telefono_TelefonoID_seq"', 1, true);
          public          postgres    false    227            
           2606    17040 !   datos_laborales Datos_LaboralesPK 
   CONSTRAINT     q   ALTER TABLE ONLY public.datos_laborales
    ADD CONSTRAINT "Datos_LaboralesPK" PRIMARY KEY (datos_laborales_id);
 M   ALTER TABLE ONLY public.datos_laborales DROP CONSTRAINT "Datos_LaboralesPK";
       public            postgres    false    223            :           2606    17383    Estatus Estatus_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public."Estatus"
    ADD CONSTRAINT "Estatus_pkey" PRIMARY KEY ("Estatus_id");
 B   ALTER TABLE ONLY public."Estatus" DROP CONSTRAINT "Estatus_pkey";
       public            postgres    false    243                       2606    17149    telefono TelefonoPK 
   CONSTRAINT     ]   ALTER TABLE ONLY public.telefono
    ADD CONSTRAINT "TelefonoPK" PRIMARY KEY ("TelefonoID");
 ?   ALTER TABLE ONLY public.telefono DROP CONSTRAINT "TelefonoPK";
       public            postgres    false    226            �           2606    16971    ciudad ciudadpk 
   CONSTRAINT     T   ALTER TABLE ONLY public.ciudad
    ADD CONSTRAINT ciudadpk PRIMARY KEY (ciudad_id);
 9   ALTER TABLE ONLY public.ciudad DROP CONSTRAINT ciudadpk;
       public            postgres    false    217                       2606    17156    cliente clientepk 
   CONSTRAINT     W   ALTER TABLE ONLY public.cliente
    ADD CONSTRAINT clientepk PRIMARY KEY (cliente_id);
 ;   ALTER TABLE ONLY public.cliente DROP CONSTRAINT clientepk;
       public            postgres    false    228            8           2606    17378    comite comitepk 
   CONSTRAINT     T   ALTER TABLE ONLY public.comite
    ADD CONSTRAINT comitepk PRIMARY KEY (comite_id);
 9   ALTER TABLE ONLY public.comite DROP CONSTRAINT comitepk;
       public            postgres    false    242            $           2606    17253    compania_tarjeta companiapk 
   CONSTRAINT     b   ALTER TABLE ONLY public.compania_tarjeta
    ADD CONSTRAINT companiapk PRIMARY KEY (compania_id);
 E   ALTER TABLE ONLY public.compania_tarjeta DROP CONSTRAINT companiapk;
       public            postgres    false    234            &           2606    17260    cuenta cuenta_num_cuenta_key 
   CONSTRAINT     ]   ALTER TABLE ONLY public.cuenta
    ADD CONSTRAINT cuenta_num_cuenta_key UNIQUE (num_cuenta);
 F   ALTER TABLE ONLY public.cuenta DROP CONSTRAINT cuenta_num_cuenta_key;
       public            postgres    false    235            (           2606    17258    cuenta cuentapk 
   CONSTRAINT     T   ALTER TABLE ONLY public.cuenta
    ADD CONSTRAINT cuentapk PRIMARY KEY (cuenta_id);
 9   ALTER TABLE ONLY public.cuenta DROP CONSTRAINT cuentapk;
       public            postgres    false    235                       2606    17203 '   departamento_banco deparatamentobancopk 
   CONSTRAINT     w   ALTER TABLE ONLY public.departamento_banco
    ADD CONSTRAINT deparatamentobancopk PRIMARY KEY (departamento_bancoid);
 Q   ALTER TABLE ONLY public.departamento_banco DROP CONSTRAINT deparatamentobancopk;
       public            postgres    false    232            �           2606    16900    departamento departamentopk 
   CONSTRAINT     f   ALTER TABLE ONLY public.departamento
    ADD CONSTRAINT departamentopk PRIMARY KEY (departamento_id);
 E   ALTER TABLE ONLY public.departamento DROP CONSTRAINT departamentopk;
       public            postgres    false    215                        2606    16969    direccion direccionPK 
   CONSTRAINT     _   ALTER TABLE ONLY public.direccion
    ADD CONSTRAINT "direccionPK" PRIMARY KEY (direccion_id);
 A   ALTER TABLE ONLY public.direccion DROP CONSTRAINT "direccionPK";
       public            postgres    false    218                       2606    17233 (   empleado empleado_correo_corporativo_key 
   CONSTRAINT     q   ALTER TABLE ONLY public.empleado
    ADD CONSTRAINT empleado_correo_corporativo_key UNIQUE (correo_corporativo);
 R   ALTER TABLE ONLY public.empleado DROP CONSTRAINT empleado_correo_corporativo_key;
       public            postgres    false    233                        2606    17231     empleado empleado_persona_id_key 
   CONSTRAINT     a   ALTER TABLE ONLY public.empleado
    ADD CONSTRAINT empleado_persona_id_key UNIQUE (persona_id);
 J   ALTER TABLE ONLY public.empleado DROP CONSTRAINT empleado_persona_id_key;
       public            postgres    false    233            "           2606    17229    empleado empleadopk 
   CONSTRAINT     Z   ALTER TABLE ONLY public.empleado
    ADD CONSTRAINT empleadopk PRIMARY KEY (empleado_id);
 =   ALTER TABLE ONLY public.empleado DROP CONSTRAINT empleadopk;
       public            postgres    false    233            .           2606    17309    estado_cuenta estado_cuentapk 
   CONSTRAINT     i   ALTER TABLE ONLY public.estado_cuenta
    ADD CONSTRAINT estado_cuentapk PRIMARY KEY (estado_cuenta_id);
 G   ALTER TABLE ONLY public.estado_cuenta DROP CONSTRAINT estado_cuentapk;
       public            postgres    false    237            B           2606    17493 #   estado_solicitud estado_solicitudpk 
   CONSTRAINT     q   ALTER TABLE ONLY public.estado_solicitud
    ADD CONSTRAINT estado_solicitudpk PRIMARY KEY (estado_solicitudid);
 M   ALTER TABLE ONLY public.estado_solicitud DROP CONSTRAINT estado_solicitudpk;
       public            postgres    false    248            @           2606    17488    estado estadopk 
   CONSTRAINT     S   ALTER TABLE ONLY public.estado
    ADD CONSTRAINT estadopk PRIMARY KEY (estadoid);
 9   ALTER TABLE ONLY public.estado DROP CONSTRAINT estadopk;
       public            postgres    false    247            6           2606    17368 )   extrafinanciamiento extrafinanciamientopk 
   CONSTRAINT     {   ALTER TABLE ONLY public.extrafinanciamiento
    ADD CONSTRAINT extrafinanciamientopk PRIMARY KEY (extrafinanciamiento_id);
 S   ALTER TABLE ONLY public.extrafinanciamiento DROP CONSTRAINT extrafinanciamientopk;
       public            postgres    false    241            4           2606    17358 1   historial_transacciones historial_transaccionespk 
   CONSTRAINT     �   ALTER TABLE ONLY public.historial_transacciones
    ADD CONSTRAINT historial_transaccionespk PRIMARY KEY (historial_transaccionesid);
 [   ALTER TABLE ONLY public.historial_transacciones DROP CONSTRAINT historial_transaccionespk;
       public            postgres    false    240            <           2606    17444    mora morapk 
   CONSTRAINT     M   ALTER TABLE ONLY public.mora
    ADD CONSTRAINT morapk PRIMARY KEY (moraid);
 5   ALTER TABLE ONLY public.mora DROP CONSTRAINT morapk;
       public            postgres    false    244            �           2606    16912 '   municipio municipio_departamento_id_key 
   CONSTRAINT     m   ALTER TABLE ONLY public.municipio
    ADD CONSTRAINT municipio_departamento_id_key UNIQUE (departamento_id);
 Q   ALTER TABLE ONLY public.municipio DROP CONSTRAINT municipio_departamento_id_key;
       public            postgres    false    216            �           2606    16982    municipio municipiopk 
   CONSTRAINT     ]   ALTER TABLE ONLY public.municipio
    ADD CONSTRAINT municipiopk PRIMARY KEY (municipio_id);
 ?   ALTER TABLE ONLY public.municipio DROP CONSTRAINT municipiopk;
       public            postgres    false    216                       2606    17023    ocupacion ocupacion_titulo_key 
   CONSTRAINT     [   ALTER TABLE ONLY public.ocupacion
    ADD CONSTRAINT ocupacion_titulo_key UNIQUE (titulo);
 H   ALTER TABLE ONLY public.ocupacion DROP CONSTRAINT ocupacion_titulo_key;
       public            postgres    false    222                       2606    17021    ocupacion ocupacionpk 
   CONSTRAINT     ]   ALTER TABLE ONLY public.ocupacion
    ADD CONSTRAINT ocupacionpk PRIMARY KEY (ocupacion_id);
 ?   ALTER TABLE ONLY public.ocupacion DROP CONSTRAINT ocupacionpk;
       public            postgres    false    222            H           2606    17585    pago_credito pago_creditopk 
   CONSTRAINT     e   ALTER TABLE ONLY public.pago_credito
    ADD CONSTRAINT pago_creditopk PRIMARY KEY (pago_creditoid);
 E   ALTER TABLE ONLY public.pago_credito DROP CONSTRAINT pago_creditopk;
       public            postgres    false    251            �           2606    16895    pais pais_nombre_pais_key 
   CONSTRAINT     [   ALTER TABLE ONLY public.pais
    ADD CONSTRAINT pais_nombre_pais_key UNIQUE (nombre_pais);
 C   ALTER TABLE ONLY public.pais DROP CONSTRAINT pais_nombre_pais_key;
       public            postgres    false    214            �           2606    16893    pais paispk 
   CONSTRAINT     N   ALTER TABLE ONLY public.pais
    ADD CONSTRAINT paispk PRIMARY KEY (pais_id);
 5   ALTER TABLE ONLY public.pais DROP CONSTRAINT paispk;
       public            postgres    false    214                       2606    17067    persona personapk 
   CONSTRAINT     W   ALTER TABLE ONLY public.persona
    ADD CONSTRAINT personapk PRIMARY KEY (persona_id);
 ;   ALTER TABLE ONLY public.persona DROP CONSTRAINT personapk;
       public            postgres    false    225                       2606    17176    puesto puestopk 
   CONSTRAINT     T   ALTER TABLE ONLY public.puesto
    ADD CONSTRAINT puestopk PRIMARY KEY (puesto_id);
 9   ALTER TABLE ONLY public.puesto DROP CONSTRAINT puestopk;
       public            postgres    false    229            >           2606    17472    quejas quejapk 
   CONSTRAINT     S   ALTER TABLE ONLY public.quejas
    ADD CONSTRAINT quejapk PRIMARY KEY (quejas_id);
 8   ALTER TABLE ONLY public.quejas DROP CONSTRAINT quejapk;
       public            postgres    false    246            F           2606    17565 ,   referencia_personal referencia_personal_pkey 
   CONSTRAINT     u   ALTER TABLE ONLY public.referencia_personal
    ADD CONSTRAINT referencia_personal_pkey PRIMARY KEY (referencia_id);
 V   ALTER TABLE ONLY public.referencia_personal DROP CONSTRAINT referencia_personal_pkey;
       public            postgres    false    250            D           2606    17510    solicitud_tarjeta solicitudpk 
   CONSTRAINT     e   ALTER TABLE ONLY public.solicitud_tarjeta
    ADD CONSTRAINT solicitudpk PRIMARY KEY (solicitud_id);
 G   ALTER TABLE ONLY public.solicitud_tarjeta DROP CONSTRAINT solicitudpk;
       public            postgres    false    249                       2606    17181    sucursal sucursalpk 
   CONSTRAINT     Z   ALTER TABLE ONLY public.sucursal
    ADD CONSTRAINT sucursalpk PRIMARY KEY (sucursal_id);
 =   ALTER TABLE ONLY public.sucursal DROP CONSTRAINT sucursalpk;
       public            postgres    false    230            *           2606    17284 "   tarjeta tarjeta_numero_tarjeta_key 
   CONSTRAINT     g   ALTER TABLE ONLY public.tarjeta
    ADD CONSTRAINT tarjeta_numero_tarjeta_key UNIQUE (numero_tarjeta);
 L   ALTER TABLE ONLY public.tarjeta DROP CONSTRAINT tarjeta_numero_tarjeta_key;
       public            postgres    false    236            ,           2606    17282    tarjeta tarjetapk 
   CONSTRAINT     W   ALTER TABLE ONLY public.tarjeta
    ADD CONSTRAINT tarjetapk PRIMARY KEY (tarjeta_id);
 ;   ALTER TABLE ONLY public.tarjeta DROP CONSTRAINT tarjetapk;
       public            postgres    false    236                       2606    17134 "   telefono telefono_num_telefono_key 
   CONSTRAINT     e   ALTER TABLE ONLY public.telefono
    ADD CONSTRAINT telefono_num_telefono_key UNIQUE (num_telefono);
 L   ALTER TABLE ONLY public.telefono DROP CONSTRAINT telefono_num_telefono_key;
       public            postgres    false    226                       2606    17191     telefonosucursal telefonosucurpk 
   CONSTRAINT     f   ALTER TABLE ONLY public.telefonosucursal
    ADD CONSTRAINT telefonosucurpk PRIMARY KEY (telefonoid);
 J   ALTER TABLE ONLY public.telefonosucursal DROP CONSTRAINT telefonosucurpk;
       public            postgres    false    231                       2606    17193 2   telefonosucursal telefonosucursal_num_telefono_key 
   CONSTRAINT     u   ALTER TABLE ONLY public.telefonosucursal
    ADD CONSTRAINT telefonosucursal_num_telefono_key UNIQUE (num_telefono);
 \   ALTER TABLE ONLY public.telefonosucursal DROP CONSTRAINT telefonosucursal_num_telefono_key;
       public            postgres    false    231                       2606    17016    tipo_documento tipo_documentopk 
   CONSTRAINT     k   ALTER TABLE ONLY public.tipo_documento
    ADD CONSTRAINT tipo_documentopk PRIMARY KEY (tipo_documentoid);
 I   ALTER TABLE ONLY public.tipo_documento DROP CONSTRAINT tipo_documentopk;
       public            postgres    false    221                       2606    17011    tipo_persona tipo_personapk 
   CONSTRAINT     e   ALTER TABLE ONLY public.tipo_persona
    ADD CONSTRAINT tipo_personapk PRIMARY KEY (tipo_personaid);
 E   ALTER TABLE ONLY public.tipo_persona DROP CONSTRAINT tipo_personapk;
       public            postgres    false    220            0           2606    17324 #   tipo_transaccion tipo_transaccionpk 
   CONSTRAINT     q   ALTER TABLE ONLY public.tipo_transaccion
    ADD CONSTRAINT tipo_transaccionpk PRIMARY KEY (tipo_transaccionid);
 M   ALTER TABLE ONLY public.tipo_transaccion DROP CONSTRAINT tipo_transaccionpk;
       public            postgres    false    238            2           2606    17329    transacciones transaccionespk 
   CONSTRAINT     h   ALTER TABLE ONLY public.transacciones
    ADD CONSTRAINT transaccionespk PRIMARY KEY (transaccionesid);
 G   ALTER TABLE ONLY public.transacciones DROP CONSTRAINT transaccionespk;
       public            postgres    false    239            i           2606    17450    mora EstatusID    FK CONSTRAINT     �   ALTER TABLE ONLY public.mora
    ADD CONSTRAINT "EstatusID" FOREIGN KEY (estatusid) REFERENCES public."Estatus"("Estatus_id") NOT VALID;
 :   ALTER TABLE ONLY public.mora DROP CONSTRAINT "EstatusID";
       public          postgres    false    244    243    3386            v           2606    17566    referencia_personal PersonaFK    FK CONSTRAINT     �   ALTER TABLE ONLY public.referencia_personal
    ADD CONSTRAINT "PersonaFK" FOREIGN KEY (persona_id) REFERENCES public.persona(persona_id) NOT VALID;
 I   ALTER TABLE ONLY public.referencia_personal DROP CONSTRAINT "PersonaFK";
       public          postgres    false    225    250    3340            ]           2606    17261    cuenta clientefk    FK CONSTRAINT     |   ALTER TABLE ONLY public.cuenta
    ADD CONSTRAINT clientefk FOREIGN KEY (cliente_id) REFERENCES public.cliente(cliente_id);
 :   ALTER TABLE ONLY public.cuenta DROP CONSTRAINT clientefk;
       public          postgres    false    3346    235    228            ^           2606    17295    tarjeta clientefk    FK CONSTRAINT     }   ALTER TABLE ONLY public.tarjeta
    ADD CONSTRAINT clientefk FOREIGN KEY (cliente_id) REFERENCES public.cliente(cliente_id);
 ;   ALTER TABLE ONLY public.tarjeta DROP CONSTRAINT clientefk;
       public          postgres    false    228    3346    236            b           2606    17310    estado_cuenta clientefk    FK CONSTRAINT     �   ALTER TABLE ONLY public.estado_cuenta
    ADD CONSTRAINT clientefk FOREIGN KEY (cliente_id) REFERENCES public.cliente(cliente_id);
 A   ALTER TABLE ONLY public.estado_cuenta DROP CONSTRAINT clientefk;
       public          postgres    false    228    237    3346            j           2606    17445    mora clientemorafk    FK CONSTRAINT     ~   ALTER TABLE ONLY public.mora
    ADD CONSTRAINT clientemorafk FOREIGN KEY (cliente_id) REFERENCES public.cliente(cliente_id);
 <   ALTER TABLE ONLY public.mora DROP CONSTRAINT clientemorafk;
       public          postgres    false    3346    244    228            w           2606    17586    pago_credito clientepago    FK CONSTRAINT     �   ALTER TABLE ONLY public.pago_credito
    ADD CONSTRAINT clientepago FOREIGN KEY (cliente_id) REFERENCES public.cliente(cliente_id);
 B   ALTER TABLE ONLY public.pago_credito DROP CONSTRAINT clientepago;
       public          postgres    false    3346    228    251            m           2606    17473    quejas clientequejafk    FK CONSTRAINT     �   ALTER TABLE ONLY public.quejas
    ADD CONSTRAINT clientequejafk FOREIGN KEY (cliente_id) REFERENCES public.cliente(cliente_id);
 ?   ALTER TABLE ONLY public.quejas DROP CONSTRAINT clientequejafk;
       public          postgres    false    246    3346    228            k           2606    17463     comitexempleado comiteempleadofk    FK CONSTRAINT     �   ALTER TABLE ONLY public.comitexempleado
    ADD CONSTRAINT comiteempleadofk FOREIGN KEY (comite_id) REFERENCES public.comite(comite_id);
 J   ALTER TABLE ONLY public.comitexempleado DROP CONSTRAINT comiteempleadofk;
       public          postgres    false    3384    245    242            o           2606    17499 "   estado_solicitud comitesolicitudfk    FK CONSTRAINT     �   ALTER TABLE ONLY public.estado_solicitud
    ADD CONSTRAINT comitesolicitudfk FOREIGN KEY (comite_id) REFERENCES public.comite(comite_id);
 L   ALTER TABLE ONLY public.estado_solicitud DROP CONSTRAINT comitesolicitudfk;
       public          postgres    false    242    248    3384            _           2606    17290    tarjeta companiafk    FK CONSTRAINT     �   ALTER TABLE ONLY public.tarjeta
    ADD CONSTRAINT companiafk FOREIGN KEY (compania_id) REFERENCES public.compania_tarjeta(compania_id);
 <   ALTER TABLE ONLY public.tarjeta DROP CONSTRAINT companiafk;
       public          postgres    false    236    3364    234            c           2606    17315    estado_cuenta cuentaesdfk    FK CONSTRAINT     �   ALTER TABLE ONLY public.estado_cuenta
    ADD CONSTRAINT cuentaesdfk FOREIGN KEY (cuenta_id) REFERENCES public.cuenta(cuenta_id);
 C   ALTER TABLE ONLY public.estado_cuenta DROP CONSTRAINT cuentaesdfk;
       public          postgres    false    237    235    3368            `           2606    17285    tarjeta cuentafk    FK CONSTRAINT     x   ALTER TABLE ONLY public.tarjeta
    ADD CONSTRAINT cuentafk FOREIGN KEY (cuentaid) REFERENCES public.cuenta(cuenta_id);
 :   ALTER TABLE ONLY public.tarjeta DROP CONSTRAINT cuentafk;
       public          postgres    false    236    3368    235            L           2606    16998    direccion cuidadfk    FK CONSTRAINT     z   ALTER TABLE ONLY public.direccion
    ADD CONSTRAINT cuidadfk FOREIGN KEY (cuidadid) REFERENCES public.ciudad(ciudad_id);
 <   ALTER TABLE ONLY public.direccion DROP CONSTRAINT cuidadfk;
       public          postgres    false    218    217    3326            d           2606    17345    transacciones cuidadtrfk    FK CONSTRAINT     �   ALTER TABLE ONLY public.transacciones
    ADD CONSTRAINT cuidadtrfk FOREIGN KEY (ciudad_id) REFERENCES public.ciudad(ciudad_id);
 B   ALTER TABLE ONLY public.transacciones DROP CONSTRAINT cuidadtrfk;
       public          postgres    false    3326    239    217            V           2606    17157    cliente datos_laboralesfk    FK CONSTRAINT     �   ALTER TABLE ONLY public.cliente
    ADD CONSTRAINT datos_laboralesfk FOREIGN KEY (datos_laborales_id) REFERENCES public.datos_laborales(datos_laborales_id);
 C   ALTER TABLE ONLY public.cliente DROP CONSTRAINT datos_laboralesfk;
       public          postgres    false    223    3338    228            M           2606    16958    direccion departamentodirecfk    FK CONSTRAINT     �   ALTER TABLE ONLY public.direccion
    ADD CONSTRAINT departamentodirecfk FOREIGN KEY (departamentoid) REFERENCES public.departamento(departamento_id);
 G   ALTER TABLE ONLY public.direccion DROP CONSTRAINT departamentodirecfk;
       public          postgres    false    218    3320    215            J           2606    16913    municipio departamentomunifk    FK CONSTRAINT     �   ALTER TABLE ONLY public.municipio
    ADD CONSTRAINT departamentomunifk FOREIGN KEY (departamento_id) REFERENCES public.departamento(departamento_id);
 F   ALTER TABLE ONLY public.municipio DROP CONSTRAINT departamentomunifk;
       public          postgres    false    215    216    3320            Z           2606    17239    empleado depatemantoemplefk    FK CONSTRAINT     �   ALTER TABLE ONLY public.empleado
    ADD CONSTRAINT depatemantoemplefk FOREIGN KEY (departamento_bancoid) REFERENCES public.departamento_banco(departamento_bancoid);
 E   ALTER TABLE ONLY public.empleado DROP CONSTRAINT depatemantoemplefk;
       public          postgres    false    3356    233    232            Q           2606    17075    persona direccionpfk    FK CONSTRAINT     �   ALTER TABLE ONLY public.persona
    ADD CONSTRAINT direccionpfk FOREIGN KEY (direccion_id) REFERENCES public.direccion(direccion_id);
 >   ALTER TABLE ONLY public.persona DROP CONSTRAINT direccionpfk;
       public          postgres    false    225    3328    218            q           2606    17516 &   solicitud_tarjeta direccionsolicitudfk    FK CONSTRAINT     �   ALTER TABLE ONLY public.solicitud_tarjeta
    ADD CONSTRAINT direccionsolicitudfk FOREIGN KEY (direccion_id) REFERENCES public.direccion(direccion_id);
 P   ALTER TABLE ONLY public.solicitud_tarjeta DROP CONSTRAINT direccionsolicitudfk;
       public          postgres    false    249    3328    218            X           2606    17182    sucursal direccionsucurfk    FK CONSTRAINT     �   ALTER TABLE ONLY public.sucursal
    ADD CONSTRAINT direccionsucurfk FOREIGN KEY (direccion_id) REFERENCES public.direccion(direccion_id);
 C   ALTER TABLE ONLY public.sucursal DROP CONSTRAINT direccionsucurfk;
       public          postgres    false    218    230    3328            l           2606    17458     comitexempleado empleadocomitefk    FK CONSTRAINT     �   ALTER TABLE ONLY public.comitexempleado
    ADD CONSTRAINT empleadocomitefk FOREIGN KEY (empleado_id) REFERENCES public.empleado(empleado_id);
 J   ALTER TABLE ONLY public.comitexempleado DROP CONSTRAINT empleadocomitefk;
       public          postgres    false    3362    245    233            n           2606    17478    quejas empleadosquejasfk    FK CONSTRAINT     �   ALTER TABLE ONLY public.quejas
    ADD CONSTRAINT empleadosquejasfk FOREIGN KEY (empleado_id) REFERENCES public.empleado(empleado_id);
 B   ALTER TABLE ONLY public.quejas DROP CONSTRAINT empleadosquejasfk;
       public          postgres    false    3362    246    233            r           2606    17531 ,   solicitud_tarjeta estado_solicitudslicitudfk    FK CONSTRAINT     �   ALTER TABLE ONLY public.solicitud_tarjeta
    ADD CONSTRAINT estado_solicitudslicitudfk FOREIGN KEY (estado_solicitudid) REFERENCES public.estado_solicitud(estado_solicitudid);
 V   ALTER TABLE ONLY public.solicitud_tarjeta DROP CONSTRAINT estado_solicitudslicitudfk;
       public          postgres    false    249    248    3394            p           2606    17494    estado_solicitud estadofk    FK CONSTRAINT     �   ALTER TABLE ONLY public.estado_solicitud
    ADD CONSTRAINT estadofk FOREIGN KEY (estadoid) REFERENCES public.estado(estadoid);
 C   ALTER TABLE ONLY public.estado_solicitud DROP CONSTRAINT estadofk;
       public          postgres    false    3392    248    247            K           2606    16983    ciudad municipiofk    FK CONSTRAINT     �   ALTER TABLE ONLY public.ciudad
    ADD CONSTRAINT municipiofk FOREIGN KEY (municipio_id) REFERENCES public.municipio(municipio_id);
 <   ALTER TABLE ONLY public.ciudad DROP CONSTRAINT municipiofk;
       public          postgres    false    216    3324    217            N           2606    16988    direccion municipioidfk    FK CONSTRAINT     �   ALTER TABLE ONLY public.direccion
    ADD CONSTRAINT municipioidfk FOREIGN KEY (municipioid) REFERENCES public.municipio(municipio_id);
 A   ALTER TABLE ONLY public.direccion DROP CONSTRAINT municipioidfk;
       public          postgres    false    3324    216    218            P           2606    17029    datos_laborales ocupacionfk    FK CONSTRAINT     �   ALTER TABLE ONLY public.datos_laborales
    ADD CONSTRAINT ocupacionfk FOREIGN KEY (ocupacion_id) REFERENCES public.ocupacion(ocupacion_id);
 E   ALTER TABLE ONLY public.datos_laborales DROP CONSTRAINT ocupacionfk;
       public          postgres    false    223    222    3336            I           2606    16901    departamento paisdeptofk    FK CONSTRAINT     {   ALTER TABLE ONLY public.departamento
    ADD CONSTRAINT paisdeptofk FOREIGN KEY (pais_id) REFERENCES public.pais(pais_id);
 B   ALTER TABLE ONLY public.departamento DROP CONSTRAINT paisdeptofk;
       public          postgres    false    3318    214    215            O           2606    16943    direccion paisfk    FK CONSTRAINT     r   ALTER TABLE ONLY public.direccion
    ADD CONSTRAINT paisfk FOREIGN KEY (paisid) REFERENCES public.pais(pais_id);
 :   ALTER TABLE ONLY public.direccion DROP CONSTRAINT paisfk;
       public          postgres    false    3318    214    218            T           2606    17167    telefono paisfk    FK CONSTRAINT     |   ALTER TABLE ONLY public.telefono
    ADD CONSTRAINT paisfk FOREIGN KEY (pais_id) REFERENCES public.pais(pais_id) NOT VALID;
 9   ALTER TABLE ONLY public.telefono DROP CONSTRAINT paisfk;
       public          postgres    false    3318    226    214            W           2606    17162    cliente personaclifk    FK CONSTRAINT     �   ALTER TABLE ONLY public.cliente
    ADD CONSTRAINT personaclifk FOREIGN KEY (persona_id) REFERENCES public.persona(persona_id);
 >   ALTER TABLE ONLY public.cliente DROP CONSTRAINT personaclifk;
       public          postgres    false    3340    228    225            [           2606    17244    empleado personaempfk    FK CONSTRAINT     �   ALTER TABLE ONLY public.empleado
    ADD CONSTRAINT personaempfk FOREIGN KEY (persona_id) REFERENCES public.persona(persona_id);
 ?   ALTER TABLE ONLY public.empleado DROP CONSTRAINT personaempfk;
       public          postgres    false    233    3340    225            s           2606    17511 $   solicitud_tarjeta personasolicitudfk    FK CONSTRAINT     �   ALTER TABLE ONLY public.solicitud_tarjeta
    ADD CONSTRAINT personasolicitudfk FOREIGN KEY (persona_id) REFERENCES public.persona(persona_id);
 N   ALTER TABLE ONLY public.solicitud_tarjeta DROP CONSTRAINT personasolicitudfk;
       public          postgres    false    3340    249    225            U           2606    17135    telefono personatelfk    FK CONSTRAINT     �   ALTER TABLE ONLY public.telefono
    ADD CONSTRAINT personatelfk FOREIGN KEY (persona_id) REFERENCES public.persona(persona_id);
 ?   ALTER TABLE ONLY public.telefono DROP CONSTRAINT personatelfk;
       public          postgres    false    3340    226    225            \           2606    17234    empleado sucursalemplfk    FK CONSTRAINT     �   ALTER TABLE ONLY public.empleado
    ADD CONSTRAINT sucursalemplfk FOREIGN KEY (sucursal_id) REFERENCES public.sucursal(sucursal_id);
 A   ALTER TABLE ONLY public.empleado DROP CONSTRAINT sucursalemplfk;
       public          postgres    false    230    233    3350            t           2606    17521 %   solicitud_tarjeta sucursalsolicitudfk    FK CONSTRAINT     �   ALTER TABLE ONLY public.solicitud_tarjeta
    ADD CONSTRAINT sucursalsolicitudfk FOREIGN KEY (sucursal_id) REFERENCES public.sucursal(sucursal_id);
 O   ALTER TABLE ONLY public.solicitud_tarjeta DROP CONSTRAINT sucursalsolicitudfk;
       public          postgres    false    230    249    3350            a           2606    17300    tarjeta sucursaltarjetafk    FK CONSTRAINT     �   ALTER TABLE ONLY public.tarjeta
    ADD CONSTRAINT sucursaltarjetafk FOREIGN KEY (sucursal_id) REFERENCES public.sucursal(sucursal_id);
 C   ALTER TABLE ONLY public.tarjeta DROP CONSTRAINT sucursaltarjetafk;
       public          postgres    false    230    3350    236            Y           2606    17194    telefonosucursal sucursaltelfk    FK CONSTRAINT     �   ALTER TABLE ONLY public.telefonosucursal
    ADD CONSTRAINT sucursaltelfk FOREIGN KEY (sucursal_id) REFERENCES public.sucursal(sucursal_id);
 H   ALTER TABLE ONLY public.telefonosucursal DROP CONSTRAINT sucursaltelfk;
       public          postgres    false    231    3350    230            h           2606    17369 "   extrafinanciamiento tarjetaextrafk    FK CONSTRAINT     �   ALTER TABLE ONLY public.extrafinanciamiento
    ADD CONSTRAINT tarjetaextrafk FOREIGN KEY (tarjeta_id) REFERENCES public.tarjeta(tarjeta_id);
 L   ALTER TABLE ONLY public.extrafinanciamiento DROP CONSTRAINT tarjetaextrafk;
       public          postgres    false    241    236    3372            u           2606    17526 $   solicitud_tarjeta tarjetasolicitudfk    FK CONSTRAINT     �   ALTER TABLE ONLY public.solicitud_tarjeta
    ADD CONSTRAINT tarjetasolicitudfk FOREIGN KEY (tarjeta_id) REFERENCES public.tarjeta(tarjeta_id);
 N   ALTER TABLE ONLY public.solicitud_tarjeta DROP CONSTRAINT tarjetasolicitudfk;
       public          postgres    false    3372    249    236            e           2606    17330    transacciones tarjetatrfk    FK CONSTRAINT     �   ALTER TABLE ONLY public.transacciones
    ADD CONSTRAINT tarjetatrfk FOREIGN KEY (tarjeta_id) REFERENCES public.tarjeta(tarjeta_id);
 C   ALTER TABLE ONLY public.transacciones DROP CONSTRAINT tarjetatrfk;
       public          postgres    false    3372    239    236            R           2606    17070    persona tipo_documentofk    FK CONSTRAINT     �   ALTER TABLE ONLY public.persona
    ADD CONSTRAINT tipo_documentofk FOREIGN KEY (tipo_documentoid) REFERENCES public.tipo_documento(tipo_documentoid);
 B   ALTER TABLE ONLY public.persona DROP CONSTRAINT tipo_documentofk;
       public          postgres    false    225    221    3332            S           2606    17080    persona tipo_personaidpfk    FK CONSTRAINT     �   ALTER TABLE ONLY public.persona
    ADD CONSTRAINT tipo_personaidpfk FOREIGN KEY (tipo_personaid) REFERENCES public.tipo_persona(tipo_personaid);
 C   ALTER TABLE ONLY public.persona DROP CONSTRAINT tipo_personaidpfk;
       public          postgres    false    220    3330    225            f           2606    17340     transacciones tipo_transaccionfk    FK CONSTRAINT     �   ALTER TABLE ONLY public.transacciones
    ADD CONSTRAINT tipo_transaccionfk FOREIGN KEY (tipo_transaccionid) REFERENCES public.tipo_transaccion(tipo_transaccionid);
 J   ALTER TABLE ONLY public.transacciones DROP CONSTRAINT tipo_transaccionfk;
       public          postgres    false    3376    238    239            g           2606    17359 %   historial_transacciones transaccionfk    FK CONSTRAINT     �   ALTER TABLE ONLY public.historial_transacciones
    ADD CONSTRAINT transaccionfk FOREIGN KEY (transaccion_id) REFERENCES public.transacciones(transaccionesid);
 O   ALTER TABLE ONLY public.historial_transacciones DROP CONSTRAINT transaccionfk;
       public          postgres    false    239    240    3378            #      x�3�,�2�L����� &      	   T   x�3501�000401�4��9CR�K�3�s
�,L��L�8!,N����L.Sc�.0ℱ93J�3/�SP������ .8�            x�3�405052150�404�4����� 0b�      "      x�3��JMK����� g      %      x�3�4����� ]         (   x�3��M,.I-rN,J�4�30�2��,N��b���� ��<            x�3�4404P  �8�b���� AH1         4   x�34500�30�4�4202�50"Nϼ�Լ�Ԣ|�Ҽ��"NC�=... �g
�         a   x�3501��t+J�K�,N�W��/J�:�0��95��(������������1�49#� $矜���O��*0�24��t��/�LI��eB��b���� ]         k   x���1
�0Eg�:A!�Aϐ5���	$g��cC!C�n��x+��Tg�,;#[�脍1�T�k����[)1�d9�Ī�6&û|��1�*n�S��@�h��� .��<�      
   �   x�3501��4��&�p6�BPj��]I9�ɉ
)�
��E���N9ez
^��y
�I9�
Fy)�
�
�
9�
�E@�9
�%@�7��(3�h���PNC.S�X�d��SiQzj��wf^:�	�"#�=... �;�         0   x�3�4CSS#SKCC�Ĕ���|��ļ�|���\�=... �o
Y      '   0   x�3����L�,ILI�2�t�SH-.H-J�2�JM�H����qqq �K         ;   x�3�4404P NC4 =��8-�L�� QS0id`d�k`�k��4����� �j�      (   2   x�3�4�J-�,N�K�W(JMK-J�K�L,�4202�54 "NC�=... +��      !      x�3�4�3�4�3�44 0�i����� CG          &   x�3�44 =N0�A�2���E���\1z\\\ �(	x      $   %   x�3�4202�50"NCCNC�30���b���� hk         X   x�3501�000�t�,.)�,�WpN�+)J̉��4�qX�s�f&�f*�$��rE�L�A�3J�3/�� �r��qqq J�         o   x�3���KO��L-��2�tL�OOL��2�tJL����I-�2�t�-(J-N,�̏��2�9�29/3�1���W(��,K-*�,��2���LN�K��c�钟\�_T���� ؜#�      +   (   x�3�4202�54 "NK+C �44 = �+F��� ��>         F   x�350����K)-J,���250�t�QN�)KL�/�r�� ��
�y� *%U�1��ʢ��D�=... �OP         l   x�305052150�404��O��I��T�M,*I��R�)��鉜�E��Y��E�y)�E��z���� ���F�Ɯ� �e�d�!�#��^��E�U0�1/F��� Ծ0�         >   x�3�t�-�IML�W���L�,)MI-�2�tO-J�+I���2��M��2s3�"�@�=... E��      &   D   x�3��IT(I,�J-IT��WH+�K��2R�Rs�KR�rS��S�9�LLu���b���� ���      *      x�305052150�404�4����� +*}      )   +   x�3�405052150�404�4C##]C �4����� �DS            x�3�4�t�)MU�ILJ������ 3��         :   x�-��  �����⑋��!5�i�V*������S��%��']���KV��)         &   x�324CNSS#SKC#NCNS�=... k��            x�3�4226 ANC�=... "�         -   x�3��LI�+�LIL�2�
���2�H,N,�/*I�b���� �S5         2   x�3�H-*��KT�*-:�6%39Q� �2���K,)-J�!�G�+F��� �e�            x�3�tIM�,��2�t.JM�b���� US         F   x�3�4�445�30�4202�5��52�44�26���ef�*�%&��Ur��X�rr��qqq �	�     