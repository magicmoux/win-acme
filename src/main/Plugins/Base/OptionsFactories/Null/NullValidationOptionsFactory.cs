﻿using PKISharp.WACS.DomainObjects;
using PKISharp.WACS.Plugins.Base.Options;
using PKISharp.WACS.Plugins.Interfaces;
using PKISharp.WACS.Services;
using System;

namespace PKISharp.WACS.Plugins.Base.Factories.Null
{
    /// <summary>
    /// Null implementation
    /// </summary>
    internal class NullValidationFactory : IValidationPluginOptionsFactory, INull
    {
        Type IHasType.Instance => typeof(object);
        string IValidationPluginOptionsFactory.ChallengeType => string.Empty;
        ValidationPluginOptions IValidationPluginOptionsFactory.Aquire(Target target, IOptionsService optionsService, IInputService inputService, RunLevel runLevel) => null;
        ValidationPluginOptions IValidationPluginOptionsFactory.Default(Target target, IOptionsService optionsService) => null;
        bool IHasName.Match(string name) => false;
        string IHasName.Name => "None";
        string IHasName.Description => null;
        Type IValidationPluginOptionsFactory.OptionsType => typeof(object);
        bool IValidationPluginOptionsFactory.CanValidate(Target target) => false;
    }
}
