#!/usr/bin/env pwsh
#
# Copyright (c) .NET Foundation and contributors. All rights reserved.
# Licensed under the MIT license. See LICENSE file in the project root for full license information.

# If this script fails, it is probably because docker drive sharing isn't enabled

$Time = [System.Diagnostics.Stopwatch]::StartNew()

function PrintElapsedTime {
    Log $([string]::Format("Elapsed time: {0}.{1}", $Time.Elapsed.Seconds, $Time.Elapsed.Milliseconds))
}

function Log {
    Param ([string] $s)
    Write-Output "###### $s"
}

function Check {
    Param ([string] $s)
    if ($LASTEXITCODE -ne 0) { 
        Log "Failed: $s"
        throw "Error case -- see failed step"
    }
}

$DockerOS = docker version -f "{{ .Server.Os }}"
$ImageName = "dotnetcore/orleans-dockerbuild"
$Dockerfile = "Dockerfile"

$Version = "0.0.3"

PrintElapsedTime

Log "Build application image"
docker build --no-cache --pull -t $ImageName -f $Dockerfile --build-arg Version=$Version .
PrintElapsedTime
Check "docker build (application)"

docker build -f ./OrleansSilo/Dockerfile -t dotnetcore/orleanssilo .
