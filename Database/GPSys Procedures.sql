USE GPSys
GO


/*INICIO PROCEDIMENTOS*/
---------------------------------------------------------------------------------------------------------------------------------------


/*Listar*/

CREATE PROC GPlistar_Clientes
AS
SELECT * FROM tbl_Cliente
GO

CREATE PROC GPlistar_Pedidos
AS
SELECT * FROM tbl_Pedido
GO


CREATE PROC GPlistar_Ordens
AS
SELECT
tbl_Ordem.Id_ord,
tbl_Cliente.Id_cli,
tbl_Cliente.Nome_do_Cliente,
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
GO



/*Buscar*/

CREATE PROC GPbuscar_Clientes
@Nome_do_Cliente varchar(30)
AS
SELECT * FROM tbl_Cliente WHERE Nome_do_Cliente LIKE @Nome_do_Cliente + '%'
GO


CREATE PROC GPbuscar_Ordens
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


CREATE PROC GPapagar_Cliente
@Id_cli int
AS
DELETE tbl_Ordem WHERE Id_cli=@Id_cli
GO

CREATE PROC GPapagar_Ordem
@Id_cli int
AS
DELETE tbl_Ordem WHERE Id_cli=@Id_cli
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

/*
		CREATE PROC GPincerir_Pedido
		@Id_ped int,
		@Cod_ped int,
		@Cod_serv int,
		@Quantidade int,
		@Preço_unitário float,
		@Total_a_pagar float,
		@Id_cli int

		AS
		INSERT INTO tbl_Pedido VALUES (@Id_ped, @Cod_ped, @Cod_serv, @Quantidade, @Preço_unitário, @Total_a_pagar, @Id_cli)
		GO
*/

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
update tbl_Ordem set Id_cli=@Id_cli, Cod_Serv=@Cod_Serv, Id_ped=@Id_ped, Total_a_pagar=@Total_a_pagar, Total_pago=@Total_pago, Divida=@Divida, Data_entrada=@Data_entrada, Data_saida=@Data_saida, Nota=@Nota, Cod_func=@Cod_func, Estado=@Estado
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





CREATE PROC GPeliminar_Pedido
@Id_ped int
AS
DELETE tbl_Ordem WHERE Id_ped=@Id_ped
GO








CREATE PROC GPmanutencao_Ordens
@Id_Ord int,
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
@Estado varchar(12),
@Acao varchar

AS

IF (@Acao = '1')
BEGIN
	DECLARE @CodNovo VARCHAR(5), @CodMaximo VARCHAR(5)
	SET @CodMaximo = (SELECT MAX(Id_ord) from tbl_Ordem)
	SET @CodMaximo = ISNULL(@CodMaximo, 'GP0000')
	SET @CodNovo = 'A' + RIGHT (RIGHT (@CodMaximo, 4) + 1001, 4)
	INSERT INTO tbl_Ordem(Id_cli, Cod_Serv, Id_ped, Total_a_pagar, Total_pago, Divida, Data_entrada, Data_saida, Nota, Cod_func, Estado)
	VALUES (@Id_cli, @Cod_Serv, @Id_ped, @Total_a_pagar, @Total_pago, @Divida, @Data_entrada, @Data_saida, @Nota, @Cod_func, @Estado)
	SET @Acao = 'Ordem ' + @CodNovo + ' em em espera'
END

ELSE IF (@Acao = '2')
BEGIN
	UPDATE tbl_Ordem SET Id_cli=@Id_cli, Cod_Serv=@Cod_Serv, Id_ped=@Id_ped, Total_a_pagar=@Total_a_pagar, Total_pago=@Total_pago, Divida=@Divida, Data_entrada=@Data_entrada, Data_saida=@Data_saida, Nota=@Nota, Cod_func=@Cod_func, Estado=@Estado
	SET @Acao = 'Ordem ' + @Id_Ord + ' alterado com sucesso'
END

ELSE IF (@Acao = '3')
BEGIN
	DELETE FROM tbl_Ordem WHERE Id_ord=@Id_Ord
	SET @Acao = 'Ordem ' + @Id_Ord + ' eliminado'
END
GO


CREATE PROC GPmanutencao_Clientes
@Id_cli int,
@Nome_do_Cliente varchar(30),
@Nuit varchar(10),
@Morada varchar(20),
@Cell varchar(20),
@Email varchar(30),
@Cidade varchar(15),
@Acao varchar

AS

IF (@Acao = 'insert')
BEGIN
	DECLARE @CodNovo VARCHAR(5), @CodMaximo VARCHAR(5)
	SET @CodMaximo = (SELECT MAX(Id_cli) from tbl_Cliente)
	SET @CodMaximo = ISNULL(@CodMaximo, 'GP0000')
	SET @CodNovo = 'A' + RIGHT (RIGHT (@CodMaximo, 4) + 1001, 4)
	INSERT INTO tbl_Cliente(Nome_do_Cliente, Nuit, Morada, Cell, Email, Cidade)
	VALUES (@Nome_do_Cliente, @Nuit, @Morada, @Cell, @Email, @Cidade)
	SET @Acao = 'Cliente ' + @CodNovo + ' em em espera'
END

ELSE IF (@Acao = 'update')
BEGIN
	UPDATE tbl_Cliente SET Nome_do_Cliente=@Nome_do_Cliente, Nuit=@Nuit, Morada=@Morada, Cell=@Cell, Email=@Email, Cidade=@Cidade
	SET @Acao = 'Dados do Cliente ' + @Id_cli + ' alterado com sucesso'
END

ELSE IF (@Acao = 'delete')
BEGIN
	DELETE FROM tbl_Cliente WHERE Id_cli=@Id_cli
	SET @Acao = 'Cliente ' + @Id_cli + ' eliminado'
END
GO


