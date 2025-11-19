CREATE PROCEDURE [dbo].[CreateFlower]
	@FlowerID INT = NULL,
    @FlowerName NVARCHAR(50) = NULL, 
    @Price NVARCHAR(50) = NULL, 
    @Quantity NVARCHAR(50) = NULL, 
    @Total NVARCHAR(50) NULL
AS
BEGIN
	INSERT INTO [dbo].[Flower Shop] ([FlowerID], [FlowerName], [Price], [Quantity],[Total])
	VALUES (@FlowerID,@FlowerName,@Price,@Quantity,@Total);
END