# Unexpected Mutable Variable Behavior in F#

This example demonstrates a subtle but important aspect of mutable variable handling in F#. When mutable variables are passed to functions, they are passed by reference, but the way this impacts in-place modification within the function can be counter-intuitive.

The `bug.fs` file shows the issue, while `bugSolution.fs` provides a corrected approach.

## Problem

The initial `swap` function correctly swaps the values of two mutable variables.  However, the `swap2` function, seemingly identical, produces the wrong result.

## Solution

The solution lies in understanding how F# handles mutable variables passed as arguments.  In `swap2`, `x2` and `y2` are passed by reference, however, this doesn't guarantee their values will be modified where they are defined unless we explicitly modify the reference.