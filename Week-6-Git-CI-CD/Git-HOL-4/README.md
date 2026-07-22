# Git-HOL-4 - Merge Conflict Resolution

## Overview

This hands-on demonstrates how to create and resolve merge conflicts in Git. It covers creating a feature branch, modifying the same file in different branches, generating a merge conflict, resolving the conflict manually, updating the `.gitignore` file, deleting the merged branch, and verifying the repository history.

---

## Objectives

- Understand merge conflicts in Git.
- Create and work with a feature branch.
- Modify the same file in multiple branches.
- Generate a merge conflict.
- Resolve merge conflicts manually.
- Update the `.gitignore` file.
- Delete merged branches.
- Verify repository history after conflict resolution.

---

## Prerequisites

- Git installed and configured.
- Git Bash installed.
- GitHub repository available.
- Basic understanding of Git branching and merging.

---

## Folder Structure

```
Git-HOL-4/
│
├── Commands/
│   ├── GitStatusBeforeBranch.png
│   ├── CreateGitWorkBranch.png
│   ├── GitStatusGitWork.png
│   ├── GitWorkCommit.png
│   ├── CheckoutMain.png
│   ├── MainCommit.png
│   ├── GitLogAll.png
│   ├── GitDiff.png
│   ├── MergeConflict.png
│   ├── ConflictResolved.png
│   ├── MergeCommit.png
│   ├── GitIgnoreCommit.png
│   ├── GitBranches.png
│   ├── DeleteGitWorkBranch.png
│   └── FinalGitLog.png
│
├── hello.xml
├── .gitignore
└── README.md
```

---

## Commands Executed

### Check Repository Status

```bash
git status
```

### Create a New Branch

```bash
git checkout -b GitWork
```

### Create hello.xml

```bash
echo "<message>Hello from GitWork Branch</message>" > hello.xml
```

### Check Repository Status

```bash
git status
```

### Stage File

```bash
git add hello.xml
```

### Commit Changes

```bash
git commit -m "Added hello.xml in GitWork"
```

### Switch to Main Branch

```bash
git checkout main
```

### Modify hello.xml

```bash
echo "<message>Hello from Main Branch</message>" > hello.xml
```

### Stage File

```bash
git add hello.xml
```

### Commit Changes

```bash
git commit -m "Updated hello.xml in main"
```

### Display Complete Commit History

```bash
git log --oneline --graph --decorate --all
```

### Compare Branches

```bash
git diff GitWork
```

### Merge Branch

```bash
git merge GitWork
```

### Resolve Merge Conflict

Edit the `hello.xml` file manually by removing the conflict markers and keeping the required content.

### Stage Resolved File

```bash
git add hello.xml
```

### Commit Merge Resolution

```bash
git commit -m "Resolved merge conflict"
```

### Update .gitignore

```bash
echo "*.bak" >> .gitignore
```

### Commit .gitignore

```bash
git add .gitignore
git commit -m "Updated .gitignore"
```

### List All Branches

```bash
git branch
```

### Delete Merged Branch

```bash
git branch -d GitWork
```

### View Final Commit History

```bash
git log --oneline --graph --decorate
```

---

## Screenshots

The **Commands** folder contains screenshots of every important step performed during this hands-on.

| Screenshot | Description |
|------------|-------------|
| GitStatusBeforeBranch.png | Repository status before creating the branch |
| CreateGitWorkBranch.png | Creation of GitWork branch |
| GitStatusGitWork.png | Repository status in GitWork branch |
| GitWorkCommit.png | Commit made in GitWork branch |
| CheckoutMain.png | Switching back to the main branch |
| MainCommit.png | Commit made in the main branch |
| GitLogAll.png | Complete Git commit history |
| GitDiff.png | Differences between main and GitWork branches |
| MergeConflict.png | Merge conflict generated during merge |
| ConflictResolved.png | Conflict resolved successfully |
| MergeCommit.png | Merge commit after conflict resolution |
| GitIgnoreCommit.png | Commit after updating `.gitignore` |
| GitBranches.png | Available branches after merge |
| DeleteGitWorkBranch.png | Deletion of merged GitWork branch |
| FinalGitLog.png | Final Git commit history |

---

## Outcome

Successfully completed the Git merge conflict resolution workflow by:

- Creating a new feature branch.
- Making independent changes in both branches.
- Generating a merge conflict.
- Resolving the conflict manually.
- Updating the `.gitignore` file.
- Committing the resolved changes.
- Deleting the merged branch.
- Verifying the final repository history and branch status.

---

## Technologies Used

- Git
- Git Bash
- GitHub
- Visual Studio Code