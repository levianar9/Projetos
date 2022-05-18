CREATE TABLE CAD_PESSOA
(
 SEQPESSOA NUMBER(15),
 NOME      VARCHAR2(100),
 CPF       NUMBER(11),
 SEXO      VARCHAR2(1),
 EMAIL     VARCHAR2(100)
);
ALTER TABLE CAD_PESSOA ADD CONSTRAINT CAD_PESSOAPK PRIMARY KEY (SEQPESSOA);

CREATE SEQUENCE S_CAD_PESSOA;


SELECT *
  FROM CAD_PESSOA A;
  
SELECT SEQPESSOA,NOME,CPF,DECODE(SEXO,'M','Masculino','Feminino')SEXO,EMAIL 
  FROM CAD_PESSOA ;