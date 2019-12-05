CREATE TABLE [dbo].[tb_cartas]
(
	[cod_cartas] tinyint NOT NULL PRIMARY KEY,
	[naipe] char NOT NULL,
	[numero] tinyint NOT NULL,
	[jogador] tinyint NULL DEFAULT 0
)
