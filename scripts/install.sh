#!/usr/bin/env sh

# shellcheck disable=SC2046,SC2103,SC2164
project_root=$(cd $(dirname "$0")/;cd ..; pwd)

dotnet new --install "$project_root"