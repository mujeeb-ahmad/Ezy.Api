using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ezy.Airport.Repository.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            INSERT INTO [dbo].[AirlineRoutes](OriginAirportCode, DestinantionAirport, CreatedBy, CreatedOn, LastUpdatedBy, LastUpdatedOn)
            VALUES
            ('NYC', 'LON',1, GETDATE(), 1, GETDATE()),
            ('NYC', 'PAR',1, GETDATE(), 1, GETDATE()),
            ('NYC', 'LAX',1, GETDATE(), 1, GETDATE()),
            ('NYC', 'ROM',1, GETDATE(), 1, GETDATE()),
            ('NYC', 'DEL',1, GETDATE(), 1, GETDATE()),
            ('NYC', 'BOM',1, GETDATE(), 1, GETDATE()),
            ('LON', 'NYC',1, GETDATE(), 1, GETDATE()),
            ('LON', 'PAR',1, GETDATE(), 1, GETDATE()),
            ('LON', 'LAX',1, GETDATE(), 1, GETDATE()),
            ('LON', 'ROM',1, GETDATE(), 1, GETDATE()),
            ('LON', 'DEL',1, GETDATE(), 1, GETDATE()),
            ('LON', 'BOM',1, GETDATE(), 1, GETDATE()),
            ('PAR', 'NYC',1, GETDATE(), 1, GETDATE()),
            ('PAR', 'LON',1, GETDATE(), 1, GETDATE()),
            ('PAR', 'LAX',1, GETDATE(), 1, GETDATE()),
            ('PAR', 'ROM',1, GETDATE(), 1, GETDATE()),
            ('PAR', 'DEL',1, GETDATE(), 1, GETDATE()),
            ('PAR', 'BOM',1, GETDATE(), 1, GETDATE()),
            ('DEL', 'NYC',1, GETDATE(), 1, GETDATE()),
            ('DEL', 'LON',1, GETDATE(), 1, GETDATE()),
            ('DEL', 'LAX',1, GETDATE(), 1, GETDATE()),
            ('DEL', 'ROM',1, GETDATE(), 1, GETDATE()),
            ('DEL', 'PAR',1, GETDATE(), 1, GETDATE()),
            ('DEL', 'BOM',1, GETDATE(), 1, GETDATE()),
            ('DEL', 'LKO',1, GETDATE(), 1, GETDATE()),
            ('DEL', 'BLR',1, GETDATE(), 1, GETDATE()),
            ('DEL', 'DXC',1, GETDATE(), 1, GETDATE()),
            ('DEL', 'SIN',1, GETDATE(), 1, GETDATE()),
            ('BOM', 'NYC',1, GETDATE(), 1, GETDATE()),
            ('BOM', 'LON',1, GETDATE(), 1, GETDATE()),
            ('BOM', 'LAX',1, GETDATE(), 1, GETDATE()),
            ('BOM', 'ROM',1, GETDATE(), 1, GETDATE()),
            ('BOM', 'PAR',1, GETDATE(), 1, GETDATE()),
            ('BOM', 'DEL',1, GETDATE(), 1, GETDATE()),
            ('BOM', 'LKO',1, GETDATE(), 1, GETDATE()),
            ('BOM', 'BLR',1, GETDATE(), 1, GETDATE()),
            ('BOM', 'DXC',1, GETDATE(), 1, GETDATE()),
            ('BOM', 'SIN',1, GETDATE(), 1, GETDATE())
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("TRUNCATE TABLE [dbo].[AirlineRoutes]");
        }
    }
}
