﻿global using BitMono.API.Configuration;
global using BitMono.API.Protecting;
global using BitMono.API.Protecting.Contexts;
global using BitMono.API.Protecting.Pipeline;
global using BitMono.API.Protecting.Resolvers;
global using BitMono.Core.Extensions.Protections;
global using BitMono.Core.Protecting.Resolvers;
global using BitMono.Obfuscation.API;
global using BitMono.Shared.Models;
global using BitMono.Utilities.Extensions.dnlib;
global using dnlib.DotNet;
global using dnlib.DotNet.MD;
global using dnlib.DotNet.Writer;
global using Microsoft.Extensions.Configuration;
global using System;
global using System.Collections.Generic;
global using System.IO;
global using System.Linq;
global using System.Reflection;
global using System.Text;
global using System.Threading;
global using System.Threading.Tasks;
global using ILogger = Serilog.ILogger;