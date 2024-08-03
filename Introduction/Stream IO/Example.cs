/*
                                ## Disposable Interface in C#


    The IDisposable interface in C# provides a mechanism for releasing unmanaged resources. 
    When a class implements the IDisposable interface, it must provide an implementation for 
    the Dispose method, which is intended to release unmanaged resources like file handles, 
    database connections, or network connections.

    Key Points:
    Purpose: To free unmanaged resources that the garbage collector does not handle.
    Usage: Implement the Dispose method to explicitly release resources.
    Pattern: Often used with the using statement to ensure Dispose is called automatically





                                    ## Unmanaged Code in C#


    Unmanaged code refers to code that executes outside the control of the .NET runtime (CLR). 
    This includes code written in languages like C or C++ that compiles directly to machine code. 
    Unmanaged code does not benefit from the automatic memory management provided by the CLR, and as such, 
    developers must manually handle memory allocation and deallocation.

    Key Points:
    Execution: Runs directly on the OS, outside the control of the CLR.
    Memory Management: Developers must manually manage memory and resources.
    Interoperability: Managed code can interact with unmanaged code using Platform 
    Invocation Services (P/Invoke) or COM Interop.

*/

using System;

public class ResourceHolder : IDisposable
{
    private bool disposed = false;

    // Simulate an unmanaged resource.
    private IntPtr unmanagedResource;

    public ResourceHolder()
    {
        // Allocate the unmanaged resource.
        //unmanagedResource = /* some allocation */;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                // Dispose managed resources if any.
            }

            // Free unmanaged resources.
            if (unmanagedResource != IntPtr.Zero)
            {
                // Free the resource.
                unmanagedResource = IntPtr.Zero;
            }

            disposed = true;
        }
    }

    ~ResourceHolder()
    {
        Dispose(false);
    }
}
