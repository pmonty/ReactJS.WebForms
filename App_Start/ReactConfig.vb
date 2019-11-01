Imports React
Imports JavaScriptEngineSwitcher.Core
Imports JavaScriptEngineSwitcher.V8

<Assembly: WebActivatorEx.PreApplicationStartMethod(GetType(ReactConfig), "Configure")>

Public Module ReactConfig
    Sub Configure()

        JsEngineSwitcher.Current.DefaultEngineName = V8JsEngine.EngineName
        JsEngineSwitcher.Current.EngineFactories.AddV8()
        '// If you want to use server-side rendering of React components, 
        '// add all the necessary JavaScript files here. This includes 
        '// your components as well as all of their dependencies.
        '// See http://reactjs.net/ for more information. Example
        ReactSiteConfiguration.Configuration = New ReactSiteConfiguration().AddScript("~/Scripts/React/index.jsx")
        '//	.AddScript("~/Scripts/First.jsx")
        '//	.AddScript("~/Scripts/Second.jsx");

        '// If you use an external build too (for example, Babel, Webpack,
        '// Browserify Or Gulp), you can improve performance by disabling 
        '// ReactJS.NET's version of Babel and loading the pre-transpiled 
        '// scripts. Example:
        '//ReactSiteConfiguration.Configuration
        '//	.SetLoadBabel(false)
        '//	.AddScriptWithoutTransform("~/Scripts/bundle.server.js")
    End Sub

End Module

