# Variables that are used throughout
$GitHubZipUrl = "https://github.com/bunnycou/GradeApp/releases/download/1.0/GradeApp.zip"
$DestinationPath = Join-Path -Path "C:\" -ChildPath "GradeApp"
$TempZipFile = Join-Path -Path $env:TEMP -ChildPath "GradeAppDownload.zip"

# Output information to the user
Write-Host "Downloading ZIP file from: $($GitHubZipUrl) to: $($TempZipFile)"
# Download the ZIP file
Invoke-WebRequest -Uri $GitHubZipUrl -OutFile $TempZipFile

# Check if the download was successful
if (Test-Path -Path $TempZipFile) {
    Write-Host "File Downloaded, Extracting contents to: $($DestinationPath)"

    # Create the destination directory if it doesn't exist
    if (-not (Test-Path -Path $DestinationPath -PathType Container)) {
        Write-Host "Creating destination folder: $($DestinationPath)"
        New-Item -Path $DestinationPath -ItemType Directory -Force | Out-Null
    } else {
        Write-Warning "Destination folder '$DestinationPath' already exists. Contents will be overwritten if files have the same name."
    }

    # Extract the contents of the ZIP file
    Write-Host "Extracting files..."
    Expand-Archive -Path $TempZipFile -DestinationPath $DestinationPath -Force

    Write-Host "Successfully extracted the contents to: $($DestinationPath)"

    # Clean up the temporary ZIP file
    Remove-Item -Path $TempZipFile -Force
    Write-Host "Removed temporary file: $($TempZipFile)"
}