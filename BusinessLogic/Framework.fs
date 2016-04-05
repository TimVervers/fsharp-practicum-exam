module Framework

// What do i need to create a fully operational deployment pipeline?
// End goal: Stateless webservice running on production server

// 1.
// Version Control System - Git 
// Bring code to GitHub by trucks

// We need a codefile
// We need a repository
// We need a truck

// 2.
// GitHub calls Travis and asks him to test and compile code
// Returns a code coverage report by mail

// 3.
// Build a container from an image
// Include sourcecode into the container (by volume mapping)

// 4.
// Bring the container to Docker Hub by truck

// 5.
// Let Docker Hub ship the container to Microsoft Azure (in America)

// 6.
// Acces container by calling him on : 0800-fsharp.com

type printName = class
    static member name = "Tim Ververs"
end

//Check if the git command is valid
let evaluateGitCommand (command:string) (expected:string) : bool =
    if command = expected then 
        true 
    else 
        false