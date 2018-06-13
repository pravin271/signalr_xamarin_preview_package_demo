# signalr_xamarin_preview_package_demo
This is a demo repository showing SignalR (1.0.0-preview1-final) working with Xamarin client. The repository contains Xamarin client and ASP.Net Core 2.0 project.

The SignalR packages which are used here,

Server: 
Microsoft.AspNetCore.SignalR - 1.0.0-preview1-final

Client:
Microsoft.AspNetCore.SignalR.Client 1.0.0-preview1-final

Visual Studio 20017 - 15.7.3
Android Target: Android 8.0

Android client installed packages (I am not sure if all this packages are installed for Signal R),

  <package id="Microsoft.AspNetCore.Http.Features" version="2.1.0-preview1-final" targetFramework="monoandroid80" />
  <package id="Microsoft.AspNetCore.SignalR.Client" version="1.0.0-preview1-final" targetFramework="monoandroid80" />
  <package id="Microsoft.AspNetCore.SignalR.Client.Core" version="1.0.0-preview1-final" targetFramework="monoandroid80" />
  <package id="Microsoft.AspNetCore.SignalR.Common" version="1.0.0-preview1-final" targetFramework="monoandroid80" />
  <package id="Microsoft.AspNetCore.Sockets.Abstractions" version="1.0.0-preview1-final" targetFramework="monoandroid80" />
  <package id="Microsoft.AspNetCore.Sockets.Client.Http" version="1.0.0-preview1-final" targetFramework="monoandroid80" />
  <package id="Microsoft.AspNetCore.Sockets.Common.Http" version="1.0.0-preview1-final" targetFramework="monoandroid80" />
  <package id="Microsoft.CSharp" version="4.3.0" targetFramework="monoandroid80" />
  <package id="Microsoft.Extensions.Configuration" version="2.1.0-preview1-final" targetFramework="monoandroid80" />
  <package id="Microsoft.Extensions.Configuration.Abstractions" version="2.1.0-preview1-final" targetFramework="monoandroid80" />
  <package id="Microsoft.Extensions.Configuration.Binder" version="2.1.0-preview1-final" targetFramework="monoandroid80" />
  <package id="Microsoft.Extensions.DependencyInjection.Abstractions" version="2.1.0-preview1-final" targetFramework="monoandroid80" />
  <package id="Microsoft.Extensions.Logging" version="2.1.0-preview1-final" targetFramework="monoandroid80" />
  <package id="Microsoft.Extensions.Logging.Abstractions" version="2.1.0-preview1-final" targetFramework="monoandroid80" />
  <package id="Microsoft.Extensions.Logging.Configuration" version="2.1.0-preview1-final" targetFramework="monoandroid80" />
  <package id="Microsoft.Extensions.Logging.Console" version="2.1.0-preview1-final" targetFramework="monoandroid80" />
  <package id="Microsoft.Extensions.Options" version="2.1.0-preview1-final" targetFramework="monoandroid80" />
  <package id="Microsoft.Extensions.Options.ConfigurationExtensions" version="2.1.0-preview1-final" targetFramework="monoandroid80" />
  <package id="Microsoft.Extensions.Primitives" version="2.1.0-preview1-final" targetFramework="monoandroid80" />
  <package id="Microsoft.NETCore.Platforms" version="1.1.0" targetFramework="monoandroid80" />
  <package id="Microsoft.Win32.Primitives" version="4.3.0" targetFramework="monoandroid80" />
  <package id="NETStandard.Library" version="1.6.1" targetFramework="monoandroid80" />
  <package id="Newtonsoft.Json" version="10.0.1" targetFramework="monoandroid80" />
  <package id="System.AppContext" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Buffers" version="4.5.0-preview1-26216-02" targetFramework="monoandroid80" />
  <package id="System.Buffers.Primitives" version="0.1.0-preview1-180216-4" targetFramework="monoandroid80" />
  <package id="System.Collections" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Collections.Concurrent" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.ComponentModel.Annotations" version="4.4.1" targetFramework="monoandroid80" />
  <package id="System.ComponentModel.Primitives" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.ComponentModel.TypeConverter" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Console" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Diagnostics.Debug" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Diagnostics.Tools" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Diagnostics.Tracing" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Dynamic.Runtime" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Globalization" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Globalization.Calendars" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.IO" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.IO.Compression" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.IO.Compression.ZipFile" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.IO.FileSystem" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.IO.FileSystem.Primitives" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.IO.Pipelines" version="0.1.0-preview1-180216-4" targetFramework="monoandroid80" />
  <package id="System.Linq" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Linq.Expressions" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Memory" version="4.5.0-preview1-26216-02" targetFramework="monoandroid80" />
  <package id="System.Net.Http" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Net.Primitives" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Net.Sockets" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Numerics.Vectors" version="4.5.0-preview1-26216-02" targetFramework="monoandroid80" />
  <package id="System.ObjectModel" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Reflection" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Reflection.Extensions" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Reflection.Primitives" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Resources.ResourceManager" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Runtime" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Runtime.CompilerServices.Unsafe" version="4.5.0-preview1-26216-02" targetFramework="monoandroid80" />
  <package id="System.Runtime.Extensions" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Runtime.Handles" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Runtime.InteropServices" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Runtime.InteropServices.RuntimeInformation" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Runtime.Numerics" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Runtime.Serialization.Formatters" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Runtime.Serialization.Primitives" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Security.Cryptography.Algorithms" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Security.Cryptography.Encoding" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Security.Cryptography.Primitives" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Security.Cryptography.X509Certificates" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Text.Encoding" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Text.Encoding.Extensions" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Text.RegularExpressions" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Threading" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Threading.Channels" version="4.5.0-preview1-26216-02" targetFramework="monoandroid80" />
  <package id="System.Threading.Tasks" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Threading.Tasks.Extensions" version="4.5.0-preview1-26216-02" targetFramework="monoandroid80" />
  <package id="System.Threading.Timer" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.ValueTuple" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Xml.ReaderWriter" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Xml.XDocument" version="4.3.0" targetFramework="monoandroid80" />
  <package id="System.Xml.XmlDocument" version="4.3.0" targetFramework="monoandroid80" />
