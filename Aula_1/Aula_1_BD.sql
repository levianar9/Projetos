CREATE TABLE CADASTRO_PESSOA 
(
 CODIGO NUMBER(6),
 NOME VARCHAR2(50),
 EMAIL VARCHAR2(50),
 TELEFONE VARCHAR2(11)
);

ALTER TABLE CADASTRO_PESSOA ADD CONSTRAINT CADASTRO_PESSOAPK PRIMARY KEY(CODIGO);

SELECT * FROM CADASTRO_PESSOA;
 