namespace BusinessLogic

module Container

type ContainerState = 
  | Unload
  | Loading
  | Loaded
  | Shipping
  | Unloading