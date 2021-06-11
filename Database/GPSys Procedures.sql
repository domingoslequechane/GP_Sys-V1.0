USE GPSys
GO


/*INICIO PROCEDIMENTOS*/
---------------------------------------------------------------------------------------------------------------------------------------


CREATE PROC GPmostrar_Cliente
AS
SELECT * FROM tbl_Cliente
GO


CREATE PROC GPmostrar_Ordem
AS
SELECT
tbl_Ordem.Id_ord,
tbl_Cliente.Id_cli,
tbl_Cliente.Nome_do_Cliente,
tbl_Servico.Nome_do_Servico,
tbl_Ordem.Total_a_pagar,
tbl_Ordem.Total_pago,
tbl_Ordem.Divida,
tbl_Ordem.Data_entrada,
tbl_Ordem.Data_saida,
tbl_Ordem.Nota,
tbl_Funcionario.Nome_do_Funcionario,
tbl_Ordem.Estado

FROM tbl_Ordem
JOIN
tbl_Cliente ON tbl_Ordem.Id_cli=tbl_Cliente.Id_cli
JOIN
tbl_Funcionario ON tbl_Ordem.Cod_func=tbl_Funcionario.Cod_func
JOIN
tbl_Servico ON tbl_Ordem.Cod_serv=tbl_Servico.Cod_serv
GO


CREATE PROC GPincerir_Ordem
@Id_cli int,
@Cod_Serv int,
@Id_ped int,
@Total_a_pagar float,
@Total_pago float,
@Divida float,
@Data_entrada date,
@Data_saida date,
@Nota varchar(100),
@Cod_func int,
@Estado varchar(12)

AS
INSERT INTO tbl_Ordem VALUES (@Id_cli, @Cod_Serv, @Id_ped, @Total_a_pagar, @Total_pago, @Divida, @Data_entrada, @Data_saida, @Nota, @Cod_func, @Estado)
GO


CREATE PROC GPincerir_Cliente
@Id_cli int,
@Nome_do_Cliente varchar(30),
@Nuit varchar(10),
@Morada varchar(20),
@Cell varchar(9),
@Email varchar(30),
@Cidade varchar(15)

AS
INSERT INTO tbl_Cliente VALUES (@Nome_do_Cliente, @Nuit, @Morada, @Cell, @Email, @Cidade)
GO


CREATE PROC GPincerir_Pedido
@Cod_serv int,
@Quantidade int,
@Preço_unitário float,
@Total_a_pagar float

AS
INSERT INTO tbl_Pedido VALUES (@Cod_serv, @Quantidade, @Preço_unitário, @Total_a_pagar)
GO


CREATE PROC GPeditar_Ordem
@Id_cli int,
@Cod_Serv int,
@Id_ped int,
@Total_a_pagar float,
@Total_pago float,
@Divida float,
@Data_entrada date,
@Data_saida date,
@Nota varchar(100),
@Cod_func int,
@Estado varchar(12)

As
update tbl_Ordem set Id_cli=@Id_cli, Cod_Serv=@Cod_Serv, Id_ped=@Id_ped, Total_a_pagar=@Total_a_pagar, Total_pago=@Total_pago, Divida=@Divida,
		Data_entrada=@Data_entrada, Data_saida=@Data_saida, Nota=@Nota, Cod_func=@Cod_func, Estado=@Estado
GO


CREATE PROC GPeditar_Cliente
@Nome_do_Cliente varchar(30),
@Nuit varchar(10),
@Morada varchar(20),
@Cell varchar(9),
@Email varchar(30),
@Cidade varchar(15)

AS
update tbl_Cliente set Nome_do_Cliente=@Nome_do_Cliente, Nuit=@Nuit, Morada=@Morada, Cell=@Cell, Email=@Email, Cidade=@Cidade
GO


CREATE PROC GPeditar_Pedido
@Cod_serv int,
@Quantidade int,
@Preço_unitário float,
@Total_a_pagar float

AS
update tbl_Pedido set Cod_serv=@Cod_serv, Quantidade=@Quantidade, Preço_unitário=@Preço_unitário, Total_a_pagar=@Total_a_pagar
GO


CREATE PROC GPeliminar_Ordem
@Id_ord int
AS
DELETE tbl_Ordem WHERE Id_ord=@Id_ord
GO


CREATE PROC GPeliminar_Cliente
@Id_cli int
AS
DELETE tbl_Ordem WHERE Id_cli=@Id_cli
GO


CREATE PROC GPeliminar_Pedido
@Id_ped int
AS
DELETE tbl_Ordem WHERE Id_ped=@Id_ped
GO


CREATE PROC GPbuscar_Ordem
@Id_cli int,
@Nome_do_Cliente varchar(30)
AS
SELECT
tbl_Ordem.Id_ord,
tbl_Ordem.Total_a_pagar,
tbl_Ordem.Total_pago,
tbl_Ordem.Divida,
tbl_Ordem.Data_entrada,
tbl_Ordem.Data_saida,
tbl_Ordem.Nota,
tbl_Ordem.Estado

FROM tbl_Ordem WHERE Id_ord LIKE @Id_cli + '%'
GO


CREATE PROC GPbuscar_Cliente
@Nome_do_Cliente varchar(30)
AS
SELECT * FROM tbl_Cliente WHERE Nome_do_Cliente LIKE @Nome_do_Cliente + '%'
GO


