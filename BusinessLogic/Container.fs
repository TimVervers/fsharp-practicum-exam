//This is the container module, defining the basic principles of a container.
module Container

// A discriminated union with empty cases (like enum)
type ContainerState = 
    | Empty
    | Unloading
    | Loading  
    | Full
    | Shipped