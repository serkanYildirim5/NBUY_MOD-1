﻿using System.Data.Entity.ModelConfiguration;

using NBUY_MOD.Entities;

namespace NBUY_MOD.DAL.Mappings
{
    public class CategoryMappings : EntityTypeConfiguration<Category>
    {
        public CategoryMappings()
        {
            ToTable("Categories");
        }
    }
}