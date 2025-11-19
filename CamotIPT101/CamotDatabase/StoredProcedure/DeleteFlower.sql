CREATE PROCEDURE [dbo].[DeleteFlower]
	@FlowerID NVARCHAR(40) = NULL
AS
BEGIN
	DELETE FROM [dbo].[Flower Shop] WHERE FlowerID = @FlowerID;
END