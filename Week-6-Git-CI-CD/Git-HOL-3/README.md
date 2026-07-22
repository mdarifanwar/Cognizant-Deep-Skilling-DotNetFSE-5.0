# Git-HOL-3 - Branching and Merging

## Overview

This hands-on demonstrates the fundamental Git branching and merging workflow. It covers creating a new branch, switching between branches, making changes in a branch, committing those changes, comparing branches, merging the branch into the main branch, viewing commit history, deleting the merged branch, and verifying the repository status.

---

## Objectives

- Understand Git branching concepts.
- Create and switch to a new branch.
- Commit changes in a feature branch.
- Compare differences between branches.
- Merge a feature branch into the main branch.
- View Git commit history.
- Delete merged branches.
- Verify repository status after merge.

---

## Prerequisites

- Git installed on Windows.
- Git Bash configured.
- GitHub repository created.
- Basic knowledge of Git commands.

---

## Folder Structure

```
Git-HOL-3/
│
├── Commands/
│   ├── GitBranch.png
│   ├── CreateBranch.png
│   ├── ListBranches.png
│   ├── GitStatusOnBranch.png
│   ├── GitCommitOnBranch.png
│   ├── GitDiff.png
│   ├── CheckoutMain.png
│   ├── GitMerge.png
│   ├── GitLog.png
│   ├── DeleteBranch.png
│   ├── FinalStatus.png
│   └── GitPush.png
│
├── BranchFile.txt
└── README.md
```

---

## Commands Executed

### Initialize Git Repository

```bash
git init
```

### List Existing Branches

```bash
git branch
```

### Create and Switch to New Branch

```bash
git checkout -b GitNewBranch
```

### Display All Branches

```bash
git branch -a
```

### Check Repository Status

```bash
git status
```

### Stage Files

```bash
git add .
```

### Commit Changes

```bash
git commit -m "Added BranchFile in GitNewBranch"
```

### Compare Branches

```bash
git diff main GitNewBranch
```

### Switch Back to Main Branch

```bash
git checkout main
```

### Merge Branch

```bash
git merge GitNewBranch
```

### View Commit History

```bash
git log --oneline --graph --decorate
```

### Delete Merged Branch

```bash
git branch -d GitNewBranch
```

### Verify Final Status

```bash
git status
```

### Push Changes to GitHub

```bash
git push origin main
```

---

## Screenshots

The **Commands** folder contains screenshots for every major step performed during this hands-on.

| Screenshot | Description |
|------------|-------------|
| GitBranch.png | Display current branch |
| CreateBranch.png | Create GitNewBranch |
| ListBranches.png | View local and remote branches |
| GitStatusOnBranch.png | Repository status on feature branch |
| GitCommitOnBranch.png | Commit changes in GitNewBranch |
| GitDiff.png | Compare main and feature branch |
| CheckoutMain.png | Switch back to main branch |
| GitMerge.png | Merge GitNewBranch into main |
| GitLog.png | Display Git commit history |
| DeleteBranch.png | Delete merged feature branch |
| FinalStatus.png | Verify repository status |
| GitPush.png | Push merged changes to GitHub |

---

## Outcome

Successfully completed the Git branching and merging workflow by:

- Creating a new feature branch.
- Making and committing changes.
- Comparing branch differences.
- Switching back to the main branch.
- Merging the feature branch.
- Viewing commit history.
- Deleting the merged branch.
- Verifying the repository status.
- Pushing the final changes to GitHub.

---

## Technologies Used

- Git
- Git Bash
- GitHub
- Visual Studio Code