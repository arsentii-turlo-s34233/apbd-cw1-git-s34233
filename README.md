It's task solution for tutorial 1 of APBD subject

By the merging of feature-max branch it wasn't Fast-forward(f-f), due to changed another branch (main), so it asks to do additional commit of merging

Merge saves exact history of branches and creates new merge-commit, but rebase do replacing of commits on the top of the target branch, producing a linear history. BUT(!) Rebase has cons as changing history and changing hash of commits

•	1. When does Git perform a fast-forward and when is a merge commit created?
– Fast-forward happens when main branch didn't get a new commit after creating another branch, which we want to merge. So there no conflicts between branches. In opposite case, if main branch got new commit and branches have differences, we need additional merge-commit to save both versions in one file.

•	2. What is the practical difference between merge and rebase?   
– **_Merge_** saves the whole history of commits as it was for real (also when we split a new branch and connect it back to main branch). **_Rebase_** top up commits of merged branch in history, so it's easier to check changes in different branches, but it also changes hash of commits.

•	3. How was the conflict resolved in your repository?    
– I decided to keep both versions because the conflict was small which will not affect the logic of program (simple Console.WriteLine() methods) and just make git symbols on comments by '//'.
