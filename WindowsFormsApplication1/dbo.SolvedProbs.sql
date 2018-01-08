CREATE TABLE [dbo].[SolvedProbs] (
    [Submited by] NVARCHAR(50) NOT NULL,
    [Solved by]   NVARCHAR(50) NOT NULL,
    [Date]        DATETIME   NOT NULL,
    [Details]     NTEXT      NOT NULL,
    [Fixed Code]  NTEXT      NOT NULL
);

