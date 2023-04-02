CREATE TABLE [dbo].[STUDENT] (
    [ID]       INT       IDENTITY (1000, 1) NOT NULL,
    [FIO]      CHAR (50) NULL,
    [COURSE]   INT       NULL,
    [GROUP]    INT       NULL,
    [AGE]      INT       NULL,
    [SPECIAL]  CHAR (30) NULL,
    [WORK]  CHAR (30) NULL,
    [AVG_MARK]  INT NULL,
    [BIRTHDAY] DATE      NULL,
    [GENDER]   CHAR (1)   NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CHECK ([GENDER] = 'm'
           OR [GENDER] = 'f')
);
