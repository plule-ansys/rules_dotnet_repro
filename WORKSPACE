load("@bazel_tools//tools/build_defs/repo:http.bzl", "http_archive")
http_archive(
    name = "io_bazel_rules_dotnet",
    sha256 = "af09aa7d41c551dd4fb643221102a2ae00dc77d4b5b27a177181e754ae5a65e2",
    strip_prefix = "rules_dotnet-586114f290ced11283492b56549664fa15d0c268",
    urls = ["https://github.com/bazelbuild/rules_dotnet/archive/586114f290ced11283492b56549664fa15d0c268.zip"],
)

# Previous commit: OK
# http_archive(
#     name = "io_bazel_rules_dotnet",
#     sha256 = "32fa0276c09bb08869d40b50c66571523a4d36cc9134d3ca69776870ebe7d362",
#     strip_prefix = "rules_dotnet-d22f064895b7139edbfdcd5e6fa49be293969147",
#     urls = ["https://github.com/bazelbuild/rules_dotnet/archive/d22f064895b7139edbfdcd5e6fa49be293969147.zip"],
# )

load("@io_bazel_rules_dotnet//dotnet:defs.bzl", "core_register_sdk", "net_register_sdk", "mono_register_sdk",
    "dotnet_register_toolchains", "dotnet_repositories", "nuget_package")

dotnet_register_toolchains()
dotnet_repositories()

# For .NET Framework:
net_register_sdk(
    net_version = "net462",
    tools_version = "net462",
)

# (only useful for nuget2bazel)
core_register_sdk("v2.1.502", name = "core_sdk")

# bazel run @io_bazel_rules_dotnet//tools/nuget2bazel:nuget2bazel.exe -- add -l system.runtime.compilerservices.unsafe 4.7.1 -p C:/path/to/rules_dotnet_assembly_references

### Generated by the tool
nuget_package(
    name = "system.runtime.compilerservices.unsafe",
    package = "system.runtime.compilerservices.unsafe",
    version = "4.7.1",
    sha256 = "52fca80d5f0ed286371cf1b519b039e9855dbf04c611f8d8479816d4eec82b85",
    core_lib = {
        "netcoreapp2.0": "ref/netstandard2.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netcoreapp2.1": "ref/netstandard2.0/System.Runtime.CompilerServices.Unsafe.dll",
    },
    net_lib = {
        "net45": "ref/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "net451": "ref/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "net452": "ref/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "net46": "ref/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "net461": "ref/net461/System.Runtime.CompilerServices.Unsafe.dll",
        "net462": "ref/net461/System.Runtime.CompilerServices.Unsafe.dll",
        "net47": "ref/net461/System.Runtime.CompilerServices.Unsafe.dll",
        "net471": "ref/net461/System.Runtime.CompilerServices.Unsafe.dll",
        "net472": "ref/net461/System.Runtime.CompilerServices.Unsafe.dll",
        "netstandard1.0": "ref/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netstandard1.1": "ref/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netstandard1.2": "ref/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netstandard1.3": "ref/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netstandard1.4": "ref/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netstandard1.5": "ref/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netstandard1.6": "ref/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
        "netstandard2.0": "ref/netstandard2.0/System.Runtime.CompilerServices.Unsafe.dll",
    },
    mono_lib = "ref/net461/System.Runtime.CompilerServices.Unsafe.dll",
    core_files = {
        "netcoreapp2.0": [
           "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.dll",
           "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "netcoreapp2.1": [
           "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.dll",
           "lib/netcoreapp2.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
    },
    net_files = {
        "net45": [
           "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
           "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "net451": [
           "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
           "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "net452": [
           "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
           "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "net46": [
           "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
           "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "net461": [
           "lib/net461/System.Runtime.CompilerServices.Unsafe.dll",
           "lib/net461/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "net462": [
           "lib/net461/System.Runtime.CompilerServices.Unsafe.dll",
           "lib/net461/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "net47": [
           "lib/net461/System.Runtime.CompilerServices.Unsafe.dll",
           "lib/net461/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "net471": [
           "lib/net461/System.Runtime.CompilerServices.Unsafe.dll",
           "lib/net461/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "net472": [
           "lib/net461/System.Runtime.CompilerServices.Unsafe.dll",
           "lib/net461/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "netstandard1.0": [
           "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
           "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "netstandard1.1": [
           "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
           "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "netstandard1.2": [
           "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
           "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "netstandard1.3": [
           "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
           "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "netstandard1.4": [
           "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
           "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "netstandard1.5": [
           "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
           "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "netstandard1.6": [
           "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.dll",
           "lib/netstandard1.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
        "netstandard2.0": [
           "lib/netstandard2.0/System.Runtime.CompilerServices.Unsafe.dll",
           "lib/netstandard2.0/System.Runtime.CompilerServices.Unsafe.xml",
        ],
    },
    mono_files = [
        "lib/net461/System.Runtime.CompilerServices.Unsafe.dll",
        "lib/net461/System.Runtime.CompilerServices.Unsafe.xml",
    ],
)
### End of generated by the tool
