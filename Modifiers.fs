module Access = 
    let w = 2
    let public x= w + 2
    let private y = x + w
    let internal z = y + x


module anotherAccess = 
    open Access 
    Access.w
    Access.x
    Access.y
    Access.z
