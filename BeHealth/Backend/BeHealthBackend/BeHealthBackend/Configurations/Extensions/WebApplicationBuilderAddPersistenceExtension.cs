﻿using BeHealthBackend.DataAccess.DbContexts;
using BeHealthBackend.DataAccess.Entities;
using BeHealthBackend.DataAccess.Entities.Validators;
using BeHealthBackend.DataAccess.Repositories;
using BeHealthBackend.DataAccess.Repositories.Interfaces;
using BeHealthBackend.DTOs.AccountDtoFolder;
using BeHealthBackend.DTOs.ImageDto;
using BeHealthBackend.Services.ClinicServices;
using BeHealthBackend.Services.DoctorServices;
using BeHealthBackend.Services.FileServices;
using BeHealthBackend.Services.PatientServices;
using BeHealthBackend.Services.RecipeServices;
using BeHealthBackend.Services.ReferralServices;
using BeHealthBackend.Services.VisitServices;
using BeHealthBackend.Services.WorkHoursServices;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BeHealthBackend.Configurations.Extensions;

public static class WebApplicationBuilderAddPersistenceExtension
{
    public static WebApplicationBuilder AddPersistence(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<BeHealthContext>(
            option => option
                .UseSqlServer(builder.Configuration.GetConnectionString("BeHealthConnectionString")));

        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
        builder.Services.AddScoped<BeHealthContext, BeHealthContext>();
        builder.Services.AddScoped<IVisitRepository, VisitRepository>();
        builder.Services.AddScoped<IVisitsService, VisitsService>();
        builder.Services.AddScoped<IDoctorService, DoctorService>();
        builder.Services.AddScoped<IPatientService, PatientService>();
        builder.Services.AddScoped<IClinicService, ClinicService>();
        builder.Services.AddScoped<IReferralService, ReferralService>();
        builder.Services.AddScoped<IRecipeService, RecipeService>();
        builder.Services.AddScoped<IWorkHoursRepository, WorkHoursRepository>();
        builder.Services.AddScoped<IWorkHoursService, WorkHoursService>();
        builder.Services.AddScoped<IPasswordHasher<Doctor>, PasswordHasher<Doctor>>();
        builder.Services.AddScoped<IPasswordHasher<Patient>, PasswordHasher<Patient>>();
        builder.Services.AddScoped<IValidator<CreateDoctorDto>, CreateDoctorDtoValidator>();
        builder.Services.AddScoped<IValidator<CreatePatientDto>, CreatePatientDtoValidator>();
        builder.Services.AddScoped<IValidator<CreateImageDto>, CreateImageDtoValidator>();
        builder.Services.AddTransient<IFileService, FileService>();

        return builder;
    }
}