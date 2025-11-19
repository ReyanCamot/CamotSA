CREATE PROCEDURE [dbo].[UpdateMotor]
	@FlowerID NVARCHAR(50) = NULL, 
    @FlowerName NVARCHAR(50) = NULL,
	@Quantity NVARCHAR(50) = NULL,
	@Price NVARCHAR(50) = NULL,
	@Total NVARCHAR(50) = NULL
AS
BEGIN
	UPDATE [dbo].[Motor]
	SET 
	[FlowerID] = @FlowerID,
    [FlowerName] = @FlowerName, 
    [Price] = @Price,
    [Quantity] = @Quantity,
	[Total] = @Total
	WHERE [FlowerID] = @FlowerID;
END