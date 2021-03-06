// GENERATED AUTOMATICALLY FROM 'Assets/_Project/Script/Input/InputControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputControls"",
    ""maps"": [
        {
            ""name"": ""playerInputControl"",
            ""id"": ""eb3a7986-d76e-4a8f-b88a-5ed4a57d9c8c"",
            ""actions"": [
                {
                    ""name"": ""AimInput"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ec7c1382-6aa8-4f73-9501-729c96170c0a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(pressPoint=0.8)""
                },
                {
                    ""name"": ""ShootInput"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2d192172-d866-4ee5-b2a1-8558949f57ea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=3.5)""
                },
                {
                    ""name"": ""MovementInput"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f50055f5-2f34-45b3-b03b-7b8f293ce3b9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""750bc808-58ab-4e9f-84d2-3a5195452c14"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6ae7f4e9-e7fa-4fde-9f27-e7c87f202efe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ea485d7e-1857-4761-8d33-9f6740c6c89d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""99dec050-c35b-48c8-b7f5-e536be171ea4"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""598d045e-2a9e-40ba-beae-0750a146029b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementInput"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c48e3b99-1fef-4329-b870-cfddb97e8f43"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9a8502bd-1971-4d18-82b2-c13da123901b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8f3ebdfb-4bc6-4195-a588-985f75374121"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a922f688-d7d8-4e18-8c22-a47d3af19dc0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""a89778e7-a7f6-48c7-939d-1fa42f5bf271"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementInput"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""254e8418-ca51-49d6-90ea-ffb29e14c072"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ff663087-f89f-46e5-b6a0-feba0dfdee41"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6093ac83-423b-4b12-a2e9-c14948a09f99"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""43810964-be50-4f8f-851e-4a099d2deaf5"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""ec90e428-dd60-4a32-be54-6c8e1cbc284b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementInput"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e94af4ca-64cb-4a1c-ad39-0416b501df48"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c01d5c87-7230-4332-bab6-66e29af1643a"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b380fac0-089a-4c54-afc6-c63e4c0fce56"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9d800340-bf5f-46ff-822c-638ddf6faa72"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""7ea655f2-74e7-4bef-933b-0fa5905b2ea3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementInput"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""bb867d8f-ac2d-40e0-b85b-c2389458aa9e"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d89f88b8-4517-4b4d-993e-2ffffcb4764e"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c481cdfd-58a5-48f9-8809-274dbef5ecb6"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9b880598-eb53-4a65-8dd8-6e778bc0cbe7"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5db750b5-4cc9-40fe-914e-d40ffee3aef6"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AimInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f8eed389-8a10-4ff4-9823-96a6fa9afc0a"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AimInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5fd83a94-d822-40c6-b745-ff87d983cd74"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b4859b9e-a77f-4eed-995a-bc02671b0fda"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""578a416a-4cc9-433d-941a-de531ca06115"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""62e1e8ee-c3f5-40bd-a04a-91b66305a16b"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""cameraInputControl"",
            ""id"": ""a5fcde86-c8c1-4f56-ad95-1cbaf34c42c3"",
            ""actions"": [
                {
                    ""name"": ""CameraAimInput"",
                    ""type"": ""PassThrough"",
                    ""id"": ""28cb1292-73e1-4bc6-a65d-b9e83353bfe0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""65a78fc1-6b14-45fc-a955-1b67b0b27378"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraAimInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60c3290c-c904-4a93-b593-3373e4161253"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=8,y=8)"",
                    ""groups"": """",
                    ""action"": ""CameraAimInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""476bd7d4-399b-4d27-9aac-680039924923"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=8,y=8)"",
                    ""groups"": """",
                    ""action"": ""CameraAimInput"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""20451a83-5d90-41ba-b04e-51765c7ddf43"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraAimInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e8e80dab-4ec5-4f7a-9529-b865072c41e5"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraAimInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""54001a21-f322-464c-b464-62f4194c9c76"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraAimInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""56a1d32d-4b65-432b-9580-24b3ccfb5792"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraAimInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""menuInputs"",
            ""id"": ""de596d2e-de5f-456b-9097-f8262acc73df"",
            ""actions"": [
                {
                    ""name"": ""menuSelect"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9734d4ef-ffc1-4526-8c23-944ab49240f5"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""menuConfirm"",
                    ""type"": ""Button"",
                    ""id"": ""282959ed-86f3-4f53-8be4-778a03b0f927"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""menuChoose"",
                    ""type"": ""PassThrough"",
                    ""id"": ""bb8b5f07-7436-4d52-a383-9dedc6f1cbc4"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""8e42f63d-99ad-48bd-8df8-d1da6d1e79f3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menuSelect"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ced817a3-edae-4677-a25d-24a1634ad8b1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menuSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""eb89d087-a8ef-4a46-b9f8-1c5deb886dbf"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menuSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""e778b6a0-11eb-42b4-817a-92a4aab72cfa"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menuSelect"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""dcd2d764-263e-42d0-ace1-74f234593c43"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menuSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""39d6339f-f4f7-4ca8-8395-98109f523c68"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menuSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""14381584-a960-4121-a959-a9cde2f85797"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menuSelect"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a574a279-05fe-49e8-a8e3-f140264b7f67"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menuSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""399f459d-29c0-4a93-93e1-0a9f3b4b360f"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menuSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""b16a5271-2809-45de-8e42-bb91d45cbdf9"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menuSelect"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b4623238-5841-4200-bda3-f17fac4d6f77"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menuSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1f4a12b4-299b-43dd-a340-8586d0459e2b"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menuSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7af797f1-4d0a-4896-b15f-1c4d4f982b9e"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menuConfirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f3f88782-43c8-4a02-a7b3-8a3c8ecb6364"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menuConfirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""c4fe7907-8b70-4ba3-bb8e-b18105cab92e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menuChoose"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""db4b2f3e-c605-49fe-9c07-9dad8a9b2669"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menuChoose"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""18d821ea-cf9f-418a-8cec-c48badd89ecd"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menuChoose"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""6a00e5b0-595b-4315-a9c0-9af83e0b2257"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menuChoose"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""769fdb10-0667-4d6b-82b1-590c4d1de12a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menuChoose"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0addb159-e6fc-4889-8593-460f0bcd8312"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menuChoose"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""97c964f6-8846-4e76-9b68-4b6d254c2946"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menuChoose"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f133f3f0-9ab9-4e12-953d-b581f04f3c60"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menuChoose"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""824cb321-2065-4043-9950-685f6a53cfee"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menuChoose"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""d15ec68a-fef4-4487-917f-601d258f4c45"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menuChoose"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""1d0399aa-5ca9-4f8e-a427-8a61316eb941"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menuChoose"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8ca5b881-6454-43cd-a6d0-faf1a622574f"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menuChoose"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""5dc94054-d34d-4d58-9910-ba0f6767d316"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menuChoose"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f894cdf9-0092-4979-9aef-82584ccc21f2"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menuChoose"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2d9c607f-ca04-4ff9-89d6-49634871cf37"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menuChoose"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""gameOverInput"",
            ""id"": ""1069646d-b707-4d12-9ba9-bed06613c065"",
            ""actions"": [
                {
                    ""name"": ""Return"",
                    ""type"": ""PassThrough"",
                    ""id"": ""fa46b6fa-29a3-4c6b-85f5-0f0d6f21e104"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TryAgain"",
                    ""type"": ""Button"",
                    ""id"": ""3b930c1d-2997-4303-9208-f25d1334b2e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e02491d2-d9d4-4bfe-a678-bd412153f098"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Return"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1eda9827-27ce-4958-9382-691c741b5c3c"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Return"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c828efe5-9fcd-414f-8854-988216dbb41a"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Return"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""670a7ecf-29d2-4b56-a6cb-582647a4497c"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TryAgain"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb97744e-3581-4fcc-b637-d71d05583beb"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TryAgain"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ed5e4857-a1b3-40a9-a5a6-49de730ae224"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TryAgain"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""matchInputs"",
            ""id"": ""f63aee5b-3cfe-4f43-8136-b759a9aea73a"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""PassThrough"",
                    ""id"": ""80fabf1c-859f-442f-8e45-96be90466fec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""75a9ac87-6d1c-4d33-9131-fb34f326c483"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2639383e-16f4-42bc-a5cf-92ef0b211f83"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // playerInputControl
        m_playerInputControl = asset.FindActionMap("playerInputControl", throwIfNotFound: true);
        m_playerInputControl_AimInput = m_playerInputControl.FindAction("AimInput", throwIfNotFound: true);
        m_playerInputControl_ShootInput = m_playerInputControl.FindAction("ShootInput", throwIfNotFound: true);
        m_playerInputControl_MovementInput = m_playerInputControl.FindAction("MovementInput", throwIfNotFound: true);
        m_playerInputControl_Jump = m_playerInputControl.FindAction("Jump", throwIfNotFound: true);
        m_playerInputControl_Run = m_playerInputControl.FindAction("Run", throwIfNotFound: true);
        // cameraInputControl
        m_cameraInputControl = asset.FindActionMap("cameraInputControl", throwIfNotFound: true);
        m_cameraInputControl_CameraAimInput = m_cameraInputControl.FindAction("CameraAimInput", throwIfNotFound: true);
        // menuInputs
        m_menuInputs = asset.FindActionMap("menuInputs", throwIfNotFound: true);
        m_menuInputs_menuSelect = m_menuInputs.FindAction("menuSelect", throwIfNotFound: true);
        m_menuInputs_menuConfirm = m_menuInputs.FindAction("menuConfirm", throwIfNotFound: true);
        m_menuInputs_menuChoose = m_menuInputs.FindAction("menuChoose", throwIfNotFound: true);
        // gameOverInput
        m_gameOverInput = asset.FindActionMap("gameOverInput", throwIfNotFound: true);
        m_gameOverInput_Return = m_gameOverInput.FindAction("Return", throwIfNotFound: true);
        m_gameOverInput_TryAgain = m_gameOverInput.FindAction("TryAgain", throwIfNotFound: true);
        // matchInputs
        m_matchInputs = asset.FindActionMap("matchInputs", throwIfNotFound: true);
        m_matchInputs_Pause = m_matchInputs.FindAction("Pause", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // playerInputControl
    private readonly InputActionMap m_playerInputControl;
    private IPlayerInputControlActions m_PlayerInputControlActionsCallbackInterface;
    private readonly InputAction m_playerInputControl_AimInput;
    private readonly InputAction m_playerInputControl_ShootInput;
    private readonly InputAction m_playerInputControl_MovementInput;
    private readonly InputAction m_playerInputControl_Jump;
    private readonly InputAction m_playerInputControl_Run;
    public struct PlayerInputControlActions
    {
        private @InputControls m_Wrapper;
        public PlayerInputControlActions(@InputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @AimInput => m_Wrapper.m_playerInputControl_AimInput;
        public InputAction @ShootInput => m_Wrapper.m_playerInputControl_ShootInput;
        public InputAction @MovementInput => m_Wrapper.m_playerInputControl_MovementInput;
        public InputAction @Jump => m_Wrapper.m_playerInputControl_Jump;
        public InputAction @Run => m_Wrapper.m_playerInputControl_Run;
        public InputActionMap Get() { return m_Wrapper.m_playerInputControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerInputControlActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerInputControlActions instance)
        {
            if (m_Wrapper.m_PlayerInputControlActionsCallbackInterface != null)
            {
                @AimInput.started -= m_Wrapper.m_PlayerInputControlActionsCallbackInterface.OnAimInput;
                @AimInput.performed -= m_Wrapper.m_PlayerInputControlActionsCallbackInterface.OnAimInput;
                @AimInput.canceled -= m_Wrapper.m_PlayerInputControlActionsCallbackInterface.OnAimInput;
                @ShootInput.started -= m_Wrapper.m_PlayerInputControlActionsCallbackInterface.OnShootInput;
                @ShootInput.performed -= m_Wrapper.m_PlayerInputControlActionsCallbackInterface.OnShootInput;
                @ShootInput.canceled -= m_Wrapper.m_PlayerInputControlActionsCallbackInterface.OnShootInput;
                @MovementInput.started -= m_Wrapper.m_PlayerInputControlActionsCallbackInterface.OnMovementInput;
                @MovementInput.performed -= m_Wrapper.m_PlayerInputControlActionsCallbackInterface.OnMovementInput;
                @MovementInput.canceled -= m_Wrapper.m_PlayerInputControlActionsCallbackInterface.OnMovementInput;
                @Jump.started -= m_Wrapper.m_PlayerInputControlActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerInputControlActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerInputControlActionsCallbackInterface.OnJump;
                @Run.started -= m_Wrapper.m_PlayerInputControlActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_PlayerInputControlActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_PlayerInputControlActionsCallbackInterface.OnRun;
            }
            m_Wrapper.m_PlayerInputControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @AimInput.started += instance.OnAimInput;
                @AimInput.performed += instance.OnAimInput;
                @AimInput.canceled += instance.OnAimInput;
                @ShootInput.started += instance.OnShootInput;
                @ShootInput.performed += instance.OnShootInput;
                @ShootInput.canceled += instance.OnShootInput;
                @MovementInput.started += instance.OnMovementInput;
                @MovementInput.performed += instance.OnMovementInput;
                @MovementInput.canceled += instance.OnMovementInput;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
            }
        }
    }
    public PlayerInputControlActions @playerInputControl => new PlayerInputControlActions(this);

    // cameraInputControl
    private readonly InputActionMap m_cameraInputControl;
    private ICameraInputControlActions m_CameraInputControlActionsCallbackInterface;
    private readonly InputAction m_cameraInputControl_CameraAimInput;
    public struct CameraInputControlActions
    {
        private @InputControls m_Wrapper;
        public CameraInputControlActions(@InputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @CameraAimInput => m_Wrapper.m_cameraInputControl_CameraAimInput;
        public InputActionMap Get() { return m_Wrapper.m_cameraInputControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraInputControlActions set) { return set.Get(); }
        public void SetCallbacks(ICameraInputControlActions instance)
        {
            if (m_Wrapper.m_CameraInputControlActionsCallbackInterface != null)
            {
                @CameraAimInput.started -= m_Wrapper.m_CameraInputControlActionsCallbackInterface.OnCameraAimInput;
                @CameraAimInput.performed -= m_Wrapper.m_CameraInputControlActionsCallbackInterface.OnCameraAimInput;
                @CameraAimInput.canceled -= m_Wrapper.m_CameraInputControlActionsCallbackInterface.OnCameraAimInput;
            }
            m_Wrapper.m_CameraInputControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CameraAimInput.started += instance.OnCameraAimInput;
                @CameraAimInput.performed += instance.OnCameraAimInput;
                @CameraAimInput.canceled += instance.OnCameraAimInput;
            }
        }
    }
    public CameraInputControlActions @cameraInputControl => new CameraInputControlActions(this);

    // menuInputs
    private readonly InputActionMap m_menuInputs;
    private IMenuInputsActions m_MenuInputsActionsCallbackInterface;
    private readonly InputAction m_menuInputs_menuSelect;
    private readonly InputAction m_menuInputs_menuConfirm;
    private readonly InputAction m_menuInputs_menuChoose;
    public struct MenuInputsActions
    {
        private @InputControls m_Wrapper;
        public MenuInputsActions(@InputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @menuSelect => m_Wrapper.m_menuInputs_menuSelect;
        public InputAction @menuConfirm => m_Wrapper.m_menuInputs_menuConfirm;
        public InputAction @menuChoose => m_Wrapper.m_menuInputs_menuChoose;
        public InputActionMap Get() { return m_Wrapper.m_menuInputs; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuInputsActions set) { return set.Get(); }
        public void SetCallbacks(IMenuInputsActions instance)
        {
            if (m_Wrapper.m_MenuInputsActionsCallbackInterface != null)
            {
                @menuSelect.started -= m_Wrapper.m_MenuInputsActionsCallbackInterface.OnMenuSelect;
                @menuSelect.performed -= m_Wrapper.m_MenuInputsActionsCallbackInterface.OnMenuSelect;
                @menuSelect.canceled -= m_Wrapper.m_MenuInputsActionsCallbackInterface.OnMenuSelect;
                @menuConfirm.started -= m_Wrapper.m_MenuInputsActionsCallbackInterface.OnMenuConfirm;
                @menuConfirm.performed -= m_Wrapper.m_MenuInputsActionsCallbackInterface.OnMenuConfirm;
                @menuConfirm.canceled -= m_Wrapper.m_MenuInputsActionsCallbackInterface.OnMenuConfirm;
                @menuChoose.started -= m_Wrapper.m_MenuInputsActionsCallbackInterface.OnMenuChoose;
                @menuChoose.performed -= m_Wrapper.m_MenuInputsActionsCallbackInterface.OnMenuChoose;
                @menuChoose.canceled -= m_Wrapper.m_MenuInputsActionsCallbackInterface.OnMenuChoose;
            }
            m_Wrapper.m_MenuInputsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @menuSelect.started += instance.OnMenuSelect;
                @menuSelect.performed += instance.OnMenuSelect;
                @menuSelect.canceled += instance.OnMenuSelect;
                @menuConfirm.started += instance.OnMenuConfirm;
                @menuConfirm.performed += instance.OnMenuConfirm;
                @menuConfirm.canceled += instance.OnMenuConfirm;
                @menuChoose.started += instance.OnMenuChoose;
                @menuChoose.performed += instance.OnMenuChoose;
                @menuChoose.canceled += instance.OnMenuChoose;
            }
        }
    }
    public MenuInputsActions @menuInputs => new MenuInputsActions(this);

    // gameOverInput
    private readonly InputActionMap m_gameOverInput;
    private IGameOverInputActions m_GameOverInputActionsCallbackInterface;
    private readonly InputAction m_gameOverInput_Return;
    private readonly InputAction m_gameOverInput_TryAgain;
    public struct GameOverInputActions
    {
        private @InputControls m_Wrapper;
        public GameOverInputActions(@InputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Return => m_Wrapper.m_gameOverInput_Return;
        public InputAction @TryAgain => m_Wrapper.m_gameOverInput_TryAgain;
        public InputActionMap Get() { return m_Wrapper.m_gameOverInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameOverInputActions set) { return set.Get(); }
        public void SetCallbacks(IGameOverInputActions instance)
        {
            if (m_Wrapper.m_GameOverInputActionsCallbackInterface != null)
            {
                @Return.started -= m_Wrapper.m_GameOverInputActionsCallbackInterface.OnReturn;
                @Return.performed -= m_Wrapper.m_GameOverInputActionsCallbackInterface.OnReturn;
                @Return.canceled -= m_Wrapper.m_GameOverInputActionsCallbackInterface.OnReturn;
                @TryAgain.started -= m_Wrapper.m_GameOverInputActionsCallbackInterface.OnTryAgain;
                @TryAgain.performed -= m_Wrapper.m_GameOverInputActionsCallbackInterface.OnTryAgain;
                @TryAgain.canceled -= m_Wrapper.m_GameOverInputActionsCallbackInterface.OnTryAgain;
            }
            m_Wrapper.m_GameOverInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Return.started += instance.OnReturn;
                @Return.performed += instance.OnReturn;
                @Return.canceled += instance.OnReturn;
                @TryAgain.started += instance.OnTryAgain;
                @TryAgain.performed += instance.OnTryAgain;
                @TryAgain.canceled += instance.OnTryAgain;
            }
        }
    }
    public GameOverInputActions @gameOverInput => new GameOverInputActions(this);

    // matchInputs
    private readonly InputActionMap m_matchInputs;
    private IMatchInputsActions m_MatchInputsActionsCallbackInterface;
    private readonly InputAction m_matchInputs_Pause;
    public struct MatchInputsActions
    {
        private @InputControls m_Wrapper;
        public MatchInputsActions(@InputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_matchInputs_Pause;
        public InputActionMap Get() { return m_Wrapper.m_matchInputs; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MatchInputsActions set) { return set.Get(); }
        public void SetCallbacks(IMatchInputsActions instance)
        {
            if (m_Wrapper.m_MatchInputsActionsCallbackInterface != null)
            {
                @Pause.started -= m_Wrapper.m_MatchInputsActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_MatchInputsActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_MatchInputsActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_MatchInputsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public MatchInputsActions @matchInputs => new MatchInputsActions(this);
    public interface IPlayerInputControlActions
    {
        void OnAimInput(InputAction.CallbackContext context);
        void OnShootInput(InputAction.CallbackContext context);
        void OnMovementInput(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
    }
    public interface ICameraInputControlActions
    {
        void OnCameraAimInput(InputAction.CallbackContext context);
    }
    public interface IMenuInputsActions
    {
        void OnMenuSelect(InputAction.CallbackContext context);
        void OnMenuConfirm(InputAction.CallbackContext context);
        void OnMenuChoose(InputAction.CallbackContext context);
    }
    public interface IGameOverInputActions
    {
        void OnReturn(InputAction.CallbackContext context);
        void OnTryAgain(InputAction.CallbackContext context);
    }
    public interface IMatchInputsActions
    {
        void OnPause(InputAction.CallbackContext context);
    }
}
