# Changelog
All notable changes to this package will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/)
and this project adheres to [Semantic Versioning](http://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Added
* SRP Asset Settings analyzer.
* Shader SRP Batcher analyzer.
* Texture anisotropic level analyzer.

### Changed
* CHANGELOG.md format to ensure it adheres to Unity standards

## [0.9.3-preview.3] - 2023-02-28

### Fixed
* Lines and bars drawing
* Missing "Read/Write" diagnostic recommendations

## [0.9.3-preview.2] - 2023-02-21

### Added
* Texture mipmaps streaming analyzer

### Fixed
* View switching cancellation

## [0.9.3-preview.1] - 2023-02-14

### Added
* Percentage formatting support
* Individual asset size percentage to Build Report
* Test utility classes to package

## [0.9.2-preview] - 2023-02-07

### Added
* Added Fog shader variant stripping analyzer
* Added IL2CPP Compiler Configuration analyzer

### Fixed
* Backwards compatibility
* Reporting of shader variants if not compiled for analysis platform
* Displaying of large values of total shader variants
* _Copy to Clipboard_ support of issue property
* Table sorting

## [0.9.1-preview] - 2023-01-24

### Added
* _UnityEngine.Object.FindObjectOfType_ usage detection
* _Settings_ asset for configuring analyzers
* _Severity_ information to diagnostics UI

### Fixed
* Names of build-generated assets in Build Report
* Parsing of unnamed shader passes in Unity 2021.2.14+
* _UnityEngine.AudioSettings_ speaker mode diagnostic

## [0.9.0-preview] - 2022-12-01

### Added
* Diagnostic area _Quality_, _Support_ and _Requirement_
* _documentation_ support to descriptor
* Issue _fixer_ support to descriptor
* Package diagnostics
* On-demand _Texture_, _AudioClip_, _Mesh_ modules
* Compute Shader Variants support

### Fixed
* Over-reporting of built shader variants count
* Export of filtered/selected non-diagnostic issues
* Build Report object name
* Text alignment and wrapping issues
* Build report steps text wrapping
* Diagnostics _critical_ property persistence after domain reload  
* Improved text search to match custom properties

## [0.8.4-preview] - 2022-09-27

### Added
* Packages module to report installed packages and dependencies

### Fixed
* Analysis platform on incremental audit
* Compilation error due to newer com.unity.nuget.mono-cecil

## [0.8.3-preview] - 2022-09-05

### Added
* HTML export support
* _Packages_ module as _Experimental_
* _params_ array allocation diagnostic

### Fixed
* *NullReferenceException* on Draw2D shader not being found

## [0.8.2-preview] - 2022-07-25

### Added
* User preferences
* Group size/time properties
* Support for analyzing all compiled Editor assemblies
* Platform selection to _Home_ screen

### Changed
* Descriptor ID type from _int_ to _string_

### Fixed
* Diagnostic Rules serialization
* *Home* page *NullReferenceException* on Build
* *NullReferenceException* on export of non-diagnostic issues
* Improved issue creation code-readability by using *ProjectIssueBuilder*

## [0.8.1-preview] - 2022-06-24

### Added
* *ProjectAuditorConfig* option to enable/disable Roslyn analyzers
* *ProjectAuditorParams* option for compiling selected assemblies
* Discard button to toolbar
* Modules selection to _Home_ screen
* Support for reporting precompiled assemblies

### Changed
* Renamed asynchronous *ProjectAuditor.Audit* to *AuditAsync*

### Fixed
* Compatibility with Unity 2022
* Improved code analysis performance by caching "resolved" types

## [0.8.0-preview] - 2022-05-20

### Added
* *ProjectAuditor.NumCategories* API
* Module-specific incremental analysis support
* Support to disable a module by default
* 'Clear Selection' and 'Filter by Description' options to context menu
* *SavePath* to configuration asset
* [Graphics Tier](https://docs.unity3d.com/ScriptReference/Rendering.GraphicsTier.html) information to reported Shader Variants
* Diagnostic message formatting support
* Dependencies panel to assembly view
* *ImporterType* to Build File properties

### Changed
* Default compilation mode to Non-Development
* Replaced *AnalyzeEditorCode* with *CompilationMode* setting

### Fixed
* Reporting of assemblies not compiled due to dependencies
* Improved code diagnostic messages
* Improved UI groups to support arbitrary grouping criteria 

### Removed
* Removed the need to have a Descriptor associated with non-diagnostic issues

## [0.7.6-preview] - 2022-04-22

### Fixed
* Build Report analysis 'Illegal characters in path' exception
* Shaders analysis 'Illegal characters in path' exception
* Compilation warnings
* Export of variants with no keywords

## [0.7.5-preview] - 2022-04-20

### Added
* Groups support to Shaders view
* Support for exporting Shader Variants as [Shader Variant Collection](https://docs.unity3d.com/ScriptReference/ShaderVariantCollection.html)

### Changed
* Optimized call tree building and visualization

## [0.7.4-preview] - 2022-03-25

### Added
* *OnRenderObject* and *OnWillRenderObject* to list of MonoBehavior critical contexts
* Compilation Time property to Assemblies view
* Public API to get float/double custom property 
* Context menu item to open selected issue 

### Changed
* Optimized viewing and sorting UI performance

### Fixed
* Closure allocation diagnostic message
* Sorting of call hierarchy nodes

## [0.7.3-preview] - 2022-03-01
### Added
* *UnityEngine.Object.name* code diagnostic
* *Severity* filters support

### Fixed
* Unreported assemblies that failed to compile
* View switching if any module is unsupported
* Database of API usage descriptors

### Removed
* Redundant API usage descriptors

## [0.7.2-preview] - 2022-01-21

### Added
* Shader *Size*, *Source Asset* and *Always Included* info to Shaders view
* Shader *Severity* column to indicate any compiler message
* *Stage*, *Pass Type* and *Platform Keywords* to Shader Variants view
* Shader Variants view right scrollable panels
* Shader Compiler Messages reporting

### Fixed
* Usage of deprecated shader API
* Shader compilation log parsing in 2021 or newer
* Cleanup of Shader Variants builds data in 2021 or newer

## [0.7.1-preview] - 2021-12-15

### Added
* Option to enable creation of BuildReport asset after each build

### Fixed
* UWP compilation issues
* *ArgumentException* on table Page Up/Down
* *InvalidOperationException* due failure to resolve asmdef
* *NullReferenceException* due to null compiler message
* *NullReferenceException* on empty table
* *ShaderCompilerData* parsing in 2021.2.0a16 or newer
* Disabling of unsupported modules
* Unreported output files from the same source asset
* Automatic creation of last BuildReport asset after build

## [0.7.0-preview] - 2021-11-29

### Added
* Documentation pages
* UI Button to open documentation page based on active view
* BuildReport Viewer UI
* Runtime Type property to BuildReport size items
* *OnAnimatorIK* and *OnAnimatorMove* to *MonoBehaviour* hot-paths

### Fixed
* *NullReferenceException* on projects with multiple dll with same name
* Variants view *ShaderRequirements* information
* Window opening after each build

## [0.6.6-preview] - 2021-10-14

### Fixed
* *ProjectReport.ExportToCSV* filtering

## [0.6.5-preview] - 2021-08-04

### Fixed
* Mono.Cecil package dependency

## [0.6.4-preview] - 2021-07-26

### Added
* *ProjectReport.ExportToCSV* to *public* API

### Fixed
* "No graphic device is available" error in batchmode

## [0.6.3-preview] - 2021-07-05

### Fixed
* *NullReferenceException* when searching Call Tree on Resources view
* *OverflowException* on reporting build sizes
* Player.log parsing if a shader name contains commas
* Persistent "Analysis in progress..." message

## [0.6.2-preview] - 2021-05-25

### Added
* Assemblies view (experimental)
* Build Report Steps view
* Overview stats to Build Report Size view

### Fixed
* Detection of HDRP mixed LitShaderMode

## [0.6.1-preview] - 2021-05-11

### Added
* HDRP settings analyzer

### Fixed
* Build Report *Build Name*
* Empty MonoBehaviour event detection
* *Graphics Tier Settings* misreporting
* Failed/cancelled report loading from file
* Improved Shader Variants analysis workflow

## [0.6.0-preview] - 2021-04-26

### Added
* Build Report support
* Compiler Messages support
* Generic types instantiation analysis
* Summary view
* Save&Load support
* *Log Shader Compilation* option to Shader Variants view
* Shaders view shortcut to Shader Variants view

### Changed
* Compilation pipeline to use AssemblyBuilder
* Shader Variants Window to simple view

### Fixed
* Shader Variants persistence in UI after Domain Reload
* Shader Variants *Compiled* column initial state
* Code Diagnostics view sorting
* Improved main documentation page

## [0.5.0-preview] - 2021-03-11

### Added
* *System.DateTime.Now* usage detection
* Descriptor's minimum/maximum version
* Splash-screen setting detection
* Zoom slider

### Changed
* Replaced tabs-like view selection with toolbar dropdown list
* Changed *Export* feature to be view-specific

### Removed
* *experimental* label from Allocation issues

### Fixed
* Reporting of issues affecting multiple areas
* Background analysis that results in code issues with empty filenames
* Android player.log parsing
* *GraphicsSettings.logWhenShaderIsCompiled* compilation error on early 2018.4.x releases 
* Reduced UI managed allocations

## [0.4.2-preview] - 2021-02-01

### Added
* *SRP Batcher* column to Shader tab
* Support for parsing *Player.log* to identify which shader variants are compiled (or not-compiled) at runtime
* Shader errors/warnings reporting via Shader 'severity' icon
* [Shader Requirements](https://docs.unity3d.com/ScriptReference/Rendering.ShaderRequirements.html) column to Shader tab

### Fixed
* Detection of API calls using a derived type
* Reporting of *Editor Default Resources* shaders
* *ReflectionTypeLoadException*
* Exception when switching focus from Area/Assembly window
* *NullReferenceException* on invalid shader or vfx shader
* *NullReferenceException* when building AssetBundles
* Shader variants reporting due to *OnPreprocessBuild* callback default order

## [0.4.1-preview] - 2020-12-14

### Added
* Support for analyzing Editor only code-paths
* *reuseCollisionCallbacks* physics API diagnostic

### Changed
* Improved Shaders auditing to report both shaders and variants in their respective tables

### Fixed
* Assembly-CSharp-firstpass asmdef warning
* Backwards compatibility

## [0.4.0-preview] - 2020-11-24

### Added
* Shader variants auditing
* "Collapse/Expand All" buttons

### Changed
* Refactoring and code quality improvements

## [0.3.1-preview] - 2020-10-23

### Added
* Dependencies view to Assets tab
* Double-click on an asset selects it in the Project Window
* CI information to documentation

### Changed
* Move call tree to the bottom of the window
* Case-sensitive string search to be optional

### Fixed
* Page up/down key bug fixes
* Unity 2017 compatibility
* Default selected assemblies
* Area names filtering
* Call-tree serialization

## [0.3.0-preview] - 2020-10-07

### Added
* Auditing of assets in Resources folders
* Shader warmup issues

### Changed
* Reorganized UI filters and mute/unmute buttons in separate foldouts
* Better names for project settings issues

### Fixed
* Issues sorting within a group
* ExportToCSV improvements

## [0.2.1-preview] - 2020-05-22

### Changed
* Improved text search UX
* Improved test coverage
* Updated documentation

### Fixed
* Background assembly analysis
* Lost issue location after domain reload
* Tree view selection when background analysis is enabled
* Yamato configuration

## [0.2.0-preview] - 2020-04-27

### Added
* Boxing allocation analyzer
* Empty *MonoBehaviour* method analyzer
* *GameObject.tag* issue type to built-in analyzer
* *StaticBatchingAndHybridPackage* analyzer
* *Object.Instantiate* and *GameObject.AddComponent* issue types to built-in analyzer
* *String.Concat* issue type to built-in analyzer
* "experimental" allocation analyzer
* Performance critical context analysis
* Detect *MonoBehaviour.Update/LateUpdate/FixedUpdate* as perf critical contexts
* Detect *ComponentSystem/JobComponentSystem.OnUpdate* as perf critical contexts
* Critical-only UI filter
* Profiler markers
* Background analysis support

### Changed
* Optimized UI refresh performance and Assembly analysis

## [0.1.0-preview] - 2019-11-20

### Added
* Config asset support
* Mute/Unmute buttons
* Assembly column

### Changed
* Replaced Filters checkboxes with Popups

## [0.0.4-preview] - 2019-10-11

### Added
* Calling Method information
* Grouped view to Script issues

### Removed
* "Resolved" checkboxes

### Fixed
* Lots of bug fixes

## [0.0.3-preview] - 2019-09-04

### Added
* Progress bar
* Package whitelist
* Tooltips

### Fixed
* Unity 2017.x backwards compatibility

## [0.0.2-preview] - 2019-08-22

### First usable version

*Replaced placeholder database with real issues to look for*. This version also allows the user to Resolve issues.

## [0.0.1-preview] - 2019-07-23

### This is the first release of *Project Auditor*

*Proof of concept, mostly developed during Hackweek 2019*.
