-- =============================================================================
-- Create: William Cubillos
-- Created on: 26/01/2018 22:03:28
-- MER Version: 1.1.0
-- =============================================================================


DROP TABLE IF EXISTS "ActivosFijos" CASCADE;

CREATE TABLE "ActivosFijos" (
	"id_ActivosFijos" integer NOT NULL GENERATED ALWAYS AS IDENTITY,
	"Nombre" character varying(100) NOT NULL,
	"Descripcion" character varying(100) NOT NULL,
	"Tipo" character varying(100) NOT NULL,
	"Serial" character varying(100) NOT NULL,
	"NumeroInterno" character varying(100) NOT NULL,
	"Peso" smallint,
	"Alto" smallint,
	"Ancho" smallint,
	"Largo" smallint,
	"ValorCompra" money NOT NULL,
	"FechaCompra" timestamp,
	"FechaBaja" timestamp,
	"Id_EstadoActual" integer NOT NULL,
	"Id_AreaPersona" integer NOT NULL,
	PRIMARY KEY("id_ActivosFijos")
);

DROP TABLE IF EXISTS "EstadoActual" CASCADE;

CREATE TABLE "EstadoActual" (
	"Id_EstadoActual" integer NOT NULL GENERATED ALWAYS AS IDENTITY,
	"Descripcion" character varying(100) NOT NULL,
	PRIMARY KEY("Id_EstadoActual")
);

DROP TABLE IF EXISTS "AreaPersona" CASCADE;

CREATE TABLE "AreaPersona" (
	"Id_AreaPersona" integer NOT NULL GENERATED ALWAYS AS IDENTITY,
	"Nombre" character varying(100) NOT NULL,
	PRIMARY KEY("Id_AreaPersona")
);

DROP TABLE IF EXISTS "Ciudad" CASCADE;

CREATE TABLE "Ciudad" (
	"Id_Ciudad" integer NOT NULL GENERATED ALWAYS AS IDENTITY,
	"Descripcion" character varying(100) NOT NULL,
	PRIMARY KEY("Id_Ciudad")
);

DROP TABLE IF EXISTS "AreaPersona_Ciudad" CASCADE;

CREATE TABLE "AreaPersona_Ciudad" (
	"Id_AreaPersona_Ciudad" bigint NOT NULL GENERATED ALWAYS AS IDENTITY,
	"Id_AreaPersona" integer NOT NULL,
	"Id_Ciudad" integer NOT NULL
);


ALTER TABLE "ActivosFijos" ADD CONSTRAINT "Ref_ActivosFijos_to_EstadoActual" FOREIGN KEY ("Id_EstadoActual")
	REFERENCES "EstadoActual"("Id_EstadoActual")
	MATCH SIMPLE
	ON DELETE NO ACTION
	ON UPDATE NO ACTION
	NOT DEFERRABLE;

ALTER TABLE "ActivosFijos" ADD CONSTRAINT "Ref_ActivosFijos_to_AreaPersona" FOREIGN KEY ("Id_AreaPersona")
	REFERENCES "AreaPersona"("Id_AreaPersona")
	MATCH SIMPLE
	ON DELETE NO ACTION
	ON UPDATE NO ACTION
	NOT DEFERRABLE;

ALTER TABLE "AreaPersona_Ciudad" ADD CONSTRAINT "Ref_AreaPersona_has_Ciudad_to_AreaPersona" FOREIGN KEY ("Id_AreaPersona")
	REFERENCES "AreaPersona"("Id_AreaPersona")
	MATCH SIMPLE
	ON DELETE NO ACTION
	ON UPDATE NO ACTION
	NOT DEFERRABLE;

ALTER TABLE "AreaPersona_Ciudad" ADD CONSTRAINT "Ref_AreaPersona_has_Ciudad_to_Ciudad" FOREIGN KEY ("Id_Ciudad")
	REFERENCES "Ciudad"("Id_Ciudad")
	MATCH SIMPLE
	ON DELETE NO ACTION
	ON UPDATE NO ACTION
	NOT DEFERRABLE;

INSERT INTO public."EstadoActual"(
	"Descripcion")
	VALUES ('Activo'),('Dado de Baja'), ('Disponible'),('En reparación'),('Asignado');
	
	INSERT INTO public."Ciudad"(
	"Descripcion")
	VALUES ('Bogotá'),('Barranquilla'),('Medellín');

	INSERT INTO public."AreaPersona"(
	"Nombre")
	VALUES ('ELBAN QUITO'),('AQUILES MANDO'), ('ELCOS CORRON');
	
	INSERT INTO public."AreaPersona_Ciudad"(
	"Id_AreaPersona","Id_Ciudad")
	VALUES (1,1),(1,2), (2,2);
	
	
