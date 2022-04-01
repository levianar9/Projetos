-- CLIENTE
CREATE TABLE CADASTRO_CLIENTE
(
 CODIGO NUMBER(9),
 NOME VARCHAR(60),
 ENDERECO VARCHAR2(30),
 BAIRRO VARCHAR2(30),
 TELEFONE VARCHAR2(15)
 );
ALTER TABLE CADASTRO_CLIENTE ADD CONSTRAINT CADASTRO_CLIENTEPK PRIMARY KEY(CODIGO);

-- TIPO PIZZA
CREATE TABLE TIPO_PIZZA
(
 SEQTIPO NUMBER(9),
 TIPO VARCHAR(60)
);
ALTER TABLE TIPO_PIZZA ADD CONSTRAINT TIPO_PIZZAPK PRIMARY KEY(SEQTIPO);

-- SABORES PIZZA
CREATE TABLE SABOR_PIZZA 
(
 SEQSABOR NUMBER(9),
 SABOR VARCHAR2(60),
 SEQTIPO NUMBER(9)
);
ALTER TABLE SABOR_PIZZA ADD CONSTRAINT SABOR_PIZZAPK PRIMARY KEY(SEQSABOR);
ALTER TABLE SABOR_PIZZA ADD CONSTRAINT SABOR_PIZZAFK FOREIGN KEY(SEQTIPO) REFERENCES TIPO_PIZZA(SEQTIPO);

-- PEDIDO 
CREATE TABLE PEDIDO_PIZZA
(
 SEQPEDIDO NUMBER(9),
 SEQCLIENTE NUMBER(9),
 SEQSABOR NUMBER(9),
 DTAPEDIDO DATE,
 QUANTIDADE NUMBER(5),
 TOTALPEDIDO NUMBER(9)
);
ALTER TABLE PEDIDO_PIZZA ADD CONSTRAINT PEDIDO_PIZZAPK PRIMARY KEY(SEQPEDIDO);
ALTER TABLE PEDIDO_PIZZA ADD CONSTRAINT PEDIDO_PIZZAFK1 FOREIGN KEY(SEQCLIENTE) REFERENCES CADASTRO_CLIENTE(CODIGO);
ALTER TABLE PEDIDO_PIZZA ADD CONSTRAINT PEDIDO_PIZZAFK2 FOREIGN KEY(SEQSABOR) REFERENCES SABOR_PIZZA(SEQSABOR);
