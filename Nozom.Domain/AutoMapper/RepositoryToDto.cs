using AutoMapper;
using AutoMapper.Configuration;
using Nozom.Data.Entities;
using Nozom.Data.Entities.Storage;
using Nozom.Infrastructure.DTO;
using Nozom.Infrastructure.DTO.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nozom.Domain.AutoMapper
{
    public static class RepositoryToDto
    {
        public static MapperConfiguration InitializeAll()
        {
            var config = new MapperConfigurationExpression { AllowNullCollections = true };
            InitializeTransaction(config);
            InitializeDaraga(config);
            InitializeDeviceState(config);
            InitializeDeviceType(config);
            InitializeBranch(config);
            InitializeCategory(config);
            InitializeItem(config);
            InitializeItems(config);
            InitializeItemTransaction(config);
            InitializePerson(config);
            return new MapperConfiguration(config);
        }

        public static void InitializeTransaction(in MapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Transaction, TransactionDTO>().ReverseMap();
        }
        public static void InitializeDaraga(in MapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Daraga, DaragaDTO>().ReverseMap();
        }
        public static void InitializeDeviceState(in MapperConfigurationExpression cfg)
        {
            cfg.CreateMap<DeviceState, DeviceStateDTO>().ReverseMap();
        }
        public static void InitializeDeviceType(in MapperConfigurationExpression cfg)
        {
            cfg.CreateMap<DeviceType, DeviceTypeDTO>().ReverseMap();
        }
        public static void InitializeBranch(in MapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Branch, BranchDTO>().ReverseMap();
        }
        public static void InitializeCategory(in MapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Category, CategoryDTO>().ReverseMap();
        }
        public static void InitializeItem(in MapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Item, ItemDTO>().ReverseMap();
        }
        public static void InitializeItems(in MapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Items, ItemsDTO>().ReverseMap();
        }
        public static void InitializeItemTransaction(in MapperConfigurationExpression cfg)
        {
            cfg.CreateMap<ItemTransaction, ItemTransactionDTO>().ReverseMap();
        }
        public static void InitializePerson(in MapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Person, PersonDTO>().ReverseMap();
        }
    }
}
