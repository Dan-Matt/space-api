--
-- PostgreSQL database dump
--

-- Dumped from database version 14.1
-- Dumped by pg_dump version 14.1

-- Started on 2023-07-03 23:18:00

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

DROP DATABASE space;
--
-- TOC entry 3311 (class 1262 OID 24576)
-- Name: space; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE space WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'English_United Kingdom.1252';


ALTER DATABASE space OWNER TO postgres;

\connect space

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 4 (class 2615 OID 24577)
-- Name: space; Type: SCHEMA; Schema: -; Owner: postgres
--

CREATE SCHEMA space;


ALTER SCHEMA space OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 210 (class 1259 OID 24642)
-- Name: planets; Type: TABLE; Schema: space; Owner: postgres
--

CREATE TABLE space.planets (
    name character varying NOT NULL,
    image_url character varying NOT NULL,
    distance_from_sun numeric NOT NULL,
    distance_from_sun_power integer NOT NULL,
    mass numeric NOT NULL,
    mass_power integer NOT NULL,
    diameter numeric NOT NULL
);


ALTER TABLE space.planets OWNER TO postgres;

--
-- TOC entry 3305 (class 0 OID 24642)
-- Dependencies: 210
-- Data for Name: planets; Type: TABLE DATA; Schema: space; Owner: postgres
--

INSERT INTO space.planets (name, image_url, distance_from_sun, distance_from_sun_power, mass, mass_power, diameter) VALUES ('Earth', 'https://cdn.mos.cms.futurecdn.net/yCPyoZDQBBcXikqxkeW2jJ-1200-80.jpg', 1.52, 8, 5.972, 24, 12742);
INSERT INTO space.planets (name, image_url, distance_from_sun, distance_from_sun_power, mass, mass_power, diameter) VALUES ('Pluto', 'https://upload.wikimedia.org/wikipedia/commons/thumb/e/ef/Pluto_in_True_Color_-_High-Res.jpg/800px-Pluto_in_True_Color_-_High-Res.jpg', 5.9, 9, 1.309, 22, 2376.6);
INSERT INTO space.planets (name, image_url, distance_from_sun, distance_from_sun_power, mass, mass_power, diameter) VALUES ('Mars', 'https://upload.wikimedia.org/wikipedia/commons/thumb/0/0c/Mars_-_August_30_2021_-_Flickr_-_Kevin_M._Gill.png/800px-Mars_-_August_30_2021_-_Flickr_-_Kevin_M._Gill.png', 2.4986, 8, 6.39, 23, 6779);
INSERT INTO space.planets (name, image_url, distance_from_sun, distance_from_sun_power, mass, mass_power, diameter) VALUES ('Mercury', 'https://upload.wikimedia.org/wikipedia/commons/thumb/4/4a/Mercury_in_true_color.jpg/800px-Mercury_in_true_color.jpg', 4.7647, 7, 3.285, 23, 4879.4);
INSERT INTO space.planets (name, image_url, distance_from_sun, distance_from_sun_power, mass, mass_power, diameter) VALUES ('Venus', 'https://astronomynow.com/wp-content/uploads/2021/08/PIA23791_fig2-2.jpg', 1.0862, 8, 4.867, 24, 12104);
INSERT INTO space.planets (name, image_url, distance_from_sun, distance_from_sun_power, mass, mass_power, diameter) VALUES ('Jupiter', 'https://space-facts.com/wp-content/uploads/jupiter-v2.jpg', 7.4174, 8, 1.898, 27, 139820);
INSERT INTO space.planets (name, image_url, distance_from_sun, distance_from_sun_power, mass, mass_power, diameter) VALUES ('Saturn', 'https://space-facts.com/wp-content/uploads/saturn-v2.jpg', 1.4626, 9, 5.683, 26, 116460);
INSERT INTO space.planets (name, image_url, distance_from_sun, distance_from_sun_power, mass, mass_power, diameter) VALUES ('Uranus', 'https://upload.wikimedia.org/wikipedia/commons/thumb/c/c9/Uranus_as_seen_by_NASA%27s_Voyager_2_%28remastered%29_-_JPEG_converted.jpg/800px-Uranus_as_seen_by_NASA%27s_Voyager_2_%28remastered%29_-_JPEG_converted.jpg', 2.9373, 9, 8.681, 25, 50724);
INSERT INTO space.planets (name, image_url, distance_from_sun, distance_from_sun_power, mass, mass_power, diameter) VALUES ('Neptune', 'https://upload.wikimedia.org/wikipedia/commons/thumb/6/63/Neptune_-_Voyager_2_%2829347980845%29_flatten_crop.jpg/640px-Neptune_-_Voyager_2_%2829347980845%29_flatten_crop.jpg', 4.473, 9, 1.024, 26, 49244);


--
-- TOC entry 3165 (class 2606 OID 24648)
-- Name: planets planets_pkey; Type: CONSTRAINT; Schema: space; Owner: postgres
--

ALTER TABLE ONLY space.planets
    ADD CONSTRAINT planets_pkey PRIMARY KEY (name);


-- Completed on 2023-07-03 23:18:00

--
-- PostgreSQL database dump complete
--

