# Cloud Hosted Learning Objective Enablement (CHLOE)

- **Unity Version:** `2020.3.21f1`

This code package is a Unity solution for development of CHLOE.

## Scenes

The current solution is broken up into the following core scenes.

- **GameManager:** Contains all the persistent logic that will run through the full lifecycle of the game client.
- **Demo:** Contains the demo environment and game logic.
- **Level:** Contains the level 0 environment and game logic.
- **Simulation:** Contains the simulation mode environment and game logic.

## Scripts

### AWS Design Approach

For the AWS integrations, I'm currently taking the approach as follows.

- Information on available AWS services and resources is stored as `ScriptableObject` instances.
  - [`ServiceSO`](./Assets/Scripts/AWS/ScriptableObjects/Service/ServiceSO.cs) defines the information stored for a supported AWS service.
    - **Ex:** Amazon S3 service
  - [`ResourceSO`](./Assets/Scripts/AWS/ScriptableObjects/Resource/ResourceSO.cs) defines the information stored for a supported resource for a given service.
    - **Ex:** Amazon S3 Bucket resource
  - [`PropertySO`](./Assets/Scripts/AWS/ScriptableObjects/Property/PropertySO.cs) defines the information stored for a property of a supported resource.
    - **Ex:** The `S3Region` property of an Amazon S3 Bucket.

The property of a resource is particularly important, since it can take a number of different forms. Some of them are below, and are set via the `PropertyType` value of the property.

- Single line of text (`PropertyTypes.SINGLE_LINE`)
- Multiple lines of text (`PropertyTypes.MULTI_LINE`)
- Boolean (`PropertyTypes.BOOLEAN`)
- Select one item from a list (`PropertyTypes.SELECT_ONE`)
- Select multiple items from a list (`PropertyTypes.SELECT_MANY`)
- A nested, complex object (`PropertyTypes.NESTED`)
- A list of values that can be edited (`PropertyTypes.EDITABLE_LIST`)

At some point, the process of adding/removing/updating service and resource support will need to be moved to a separate application, UI, or other process in order to make things faster to keep up with the flood of AWS releases.

#### List Properties

For properties that are defined by selecting from a list, a source has to be defined so that the UI can present the right values and controls. For exmaple, the Canned ACL property of an S3 bucket can be one of a list of existing items. The list of values is defined in the [`S3CannedACLs`](./Assets/Scripts/AWS/ScriptableObjects/ListSource/S3/S3CannedACLs.cs) class.

Any list property (`SELECT_ONE` or `SELECT_MANY`) must define a value for `ListSource`, which must be a class that derives the [`ListSource`](./Assets/Scripts/AWS/Classes/ListSource.cs) class and [`IListProperty`](./Assets/Scripts/AWS/Interfaces/IListProperty.cs) interface.

#### Nested Properties

Nested properties are properties made up of other sub-properties. For example, the Grants property of an Amazon S3 Bucket is a list of Grant objects, which are objects that contain Grantee, Grantee Type, and Permission properties.

Any nested property (`NESTED` or `EDITABLE_LIST`) must define a value for `NestedSource`, which must be a class that derives the [`NestedSource`](./Assets/Scripts/AWS/Classes/NestedSource.cs) class and [`INestedProperty`](./Assets/Scripts/AWS/Interfaces/INestedProperty.cs) interface.

#### Launching Resources In-Game

When a player wants to launch a resource, they will create an instance of the resource's prefab in-game. This will need to include a reference to the `ScriptableObject` that defines the resource and its properties, and will need to define the values of all the properties, current live state in the AWS account, etc. This will be defined in the [`Resource`](./Assets/Scripts/Classes/../AWS/Classes/Resource.cs) at some point.

### Game Approach

Much like AWS services and resources, game levels and other info are also stored in `ScriptableObject` instances.

- [`LevelSO`](Assets/Scripts/Game/ScriptableObjects/LevelSO.cs) defines the information needed for a level (scene, description, number, etc.).
- 

## AWS Configuration

The [AWS SDK for .NET](https://aws.amazon.com/sdk-for-net/) has special requirements for Unity support listed [here](https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/unity-special.html). The following steps must be performed to make sure your project has the right DLL references, as Unity won't pick them up when installed via NuGet. Additionally, Unity apps must target .NET STandar 2.0 or .NET 4.x.

1. In the Visual Studio project, add references to the below.
   1. `Microsoft.Bcl.AsyncInterfaces.dll`
   1. `System.Runtime.CompilerServices.Unsafe.dll`
   1. `System.Threading.Tasks.Extensions.dll`
1. Download the .NET 4.x assemblies following [these instructions](https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/net-dg-obtain-assemblies.html#download-zip-files). The specific download is `aws-sdk-net45.zip`.
1. Extract the files and save them to `Assets/Plugins/AWSAssemblies` in the Unity project.
1. Give Unity time to update the asset list.
