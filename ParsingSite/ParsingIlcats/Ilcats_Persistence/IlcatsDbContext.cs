using IlCats_Domain.Entity.Car;
using Microsoft.EntityFrameworkCore;
using Parsing_IlCats;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ilcats_Persistence
{
    public class IlcatsDbContext : DbContext
    {
        public IlcatsDbContext(DbContextOptions<IlcatsDbContext> options) : base(options) { }
        public DbSet<ModelCar> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(IlcatsDbContext).Assembly);

            Parsing_Catalog parsingCatalog = new Parsing_Catalog();
            parsingCatalog.Start();

            var _modelCar_Id = 1;
            var _modelCarType_Id = 1;
            var _complectationVariable_Id = 1;
            var _sparePart_Id = 1;
            var _spareTypeDetail_Id = 1;

            for (var i = 0; i < parsingCatalog.DivNames.Count; i++)
            {
                builder.Entity<ModelCar>().HasData(new ModelCar
                {
                    Id = _modelCar_Id,
                    Name = $"{parsingCatalog.DivNames.ElementAt(i)}",
                });

                for (var j = 0; j < parsingCatalog.DivCode_n.ElementAt(i).Count; j++)
                {
                    builder.Entity<ModelCarType>().HasData(new ModelCarType
                    {
                        Id = _modelCarType_Id,
                        Code = $"{parsingCatalog.DivCode_n.ElementAt(i).ElementAtOrDefault(j)}",
                        DateFrom = parsingCatalog.DivDateFrom_n.ElementAt(i).ElementAtOrDefault(j),
                        DateTo = parsingCatalog.DivDateTo_n.ElementAt(i).ElementAtOrDefault(j),
                        Complectation = $"{parsingCatalog.DivComplectation_n.ElementAt(i).ElementAtOrDefault(j)}",

                        ModelCarId = _modelCar_Id,

                    });


                    // <-------------All privious inform. are correct.

                    // -------------> Next inf. - moack data


                    for (var c = 0; c < 1; c++)
                    {
                        builder.Entity<ComplectationVariable>().HasData(new ComplectationVariable
                        {
                            Id = _complectationVariable_Id,
                            Complectation = $"test _{_modelCar_Id}_ Complectation",
                            DateFrom = parsingCatalog.DivDateFrom_n.ElementAt(i).ElementAtOrDefault(_modelCar_Id),
                            DateTo = parsingCatalog.DivDateTo_n.ElementAt(i).ElementAtOrDefault(_modelCar_Id),
                            Engine = $"test _{_modelCar_Id}_ Engine",
                            Grade = $"test _{_modelCar_Id}_ Grade",
                            AtmMtm = $"test _{_modelCar_Id}_ Atm Mtm",
                            GearShiftType = $"test _{_modelCar_Id}_ Gear Shift Type",
                            DriversPosition = $"test _{_modelCar_Id}_ Driver Position",
                            FuelInduction = $"test _{_modelCar_Id}_ FuelInduction",

                            ModelCarTypeId = _modelCarType_Id,
                        });

                        for (var e = 0; e < 1; e++)
                        {
                            builder.Entity<SparePart>().HasData(new SparePart
                            {
                                Id = _sparePart_Id,
                                Name = $"test _ {_modelCar_Id}_1_ Name complectation",

                                ComplectationVariableId = _complectationVariable_Id,
                            });

                            for (var t = 0; t < 1; t++)
                            {

                                builder.Entity<SpareTypeDetail>().HasData(new SpareTypeDetail
                                {
                                    Id = _spareTypeDetail_Id,

                                    Code = 123,
                                    Quantity = 123,
                                    DateFrom = parsingCatalog.DivDateFrom_n.ElementAt(i).ElementAtOrDefault(_modelCar_Id),
                                    DateTo = parsingCatalog.DivDateTo_n.ElementAt(i).ElementAtOrDefault(_modelCar_Id),
                                    Applying = $"test _{_modelCar_Id}_{j + 1}_ Driver Position",

                                    SparePartId = _sparePart_Id,
                                });
                                _spareTypeDetail_Id += 1;
                            }
                            _sparePart_Id += 1;
                        }
                        _complectationVariable_Id += 1;
                    }
                    _modelCarType_Id += 1;
                }
                _modelCar_Id += 1;
            }
        }
    }
}
  