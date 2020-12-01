# mklink /D <ProjectName> ..\..\Blend\<ProjectName>\Unity\Assets
# Rename the parent of the assets folder to unity for clarity

@setlocal enableextensions
@cd /d "%~dp0"
mklink /D Main ..\..\UserInterface\Main\Unity\Assets