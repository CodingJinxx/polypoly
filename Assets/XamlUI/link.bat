# mklink /D <ProjectName> ..\..\Blend\<ProjectName>\<ProjectName>\Assets
# Rename the parent of the assets folder to unity for clarity

@setlocal enableextensions
@cd /d "%~dp0"
mklink /D HUD ..\..\UserInterface\HUD\HUD\Assets
mklink /D Resource ..\..\UserInterface\Resources\Resources