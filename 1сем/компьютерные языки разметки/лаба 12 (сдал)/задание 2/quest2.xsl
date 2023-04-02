<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
    <html>
    <head>
        <title>Оценки</title>
    </head>
    <body>
    <table border="1">
        <tr bgcolor="gray">
            <th>Имя</th>
            <th>Предмет 1</th>
            <th>Предмет 2</th>
            <th>Предмет 3</th>
            <th>Предмет 4</th>
        </tr>
        <xsl:for-each select="body/people">
        <tr>
            <td><xsl:value-of select="name"/></td>
            <xsl:choose>
                <xsl:when test="rating1 &gt; 8">
                    <td bgcolor="green">
                <xsl:value-of select="rating1"/></td>
                </xsl:when>
                <xsl:when test="rating1 &lt; 4">
                    <td bgcolor="red">
                <xsl:value-of select="rating1"/></td>
                </xsl:when>
                <xsl:otherwise>
                    <td><xsl:value-of select="rating1"/></td>
                </xsl:otherwise>
                </xsl:choose>
            <xsl:choose>
                <xsl:when test="rating2 &gt; 8">
                    <td bgcolor="green">
                <xsl:value-of select="rating2"/></td>
                </xsl:when>
                <xsl:when test="rating2 &lt; 4">
                    <td bgcolor="red">
                <xsl:value-of select="rating2"/></td>
                </xsl:when>
                <xsl:otherwise>
                    <td><xsl:value-of select="rating2"/></td>
                </xsl:otherwise>
                </xsl:choose>
            <xsl:choose>
                <xsl:when test="rating3 &gt; 8">
                    <td bgcolor="green">
                <xsl:value-of select="rating3"/></td>
                </xsl:when>
                <xsl:when test="rating3 &lt; 4">
                    <td bgcolor="red">
                <xsl:value-of select="rating3"/></td>
                </xsl:when>
                <xsl:otherwise>
                    <td><xsl:value-of select="rating3"/></td>
                </xsl:otherwise>
                </xsl:choose>
            <xsl:choose>
                <xsl:when test="rating4 &gt; 8">
                    <td bgcolor="green">
                <xsl:value-of select="rating4"/></td>
                </xsl:when>
                <xsl:when test="rating4 &lt; 4">
                    <td bgcolor="red">
                <xsl:value-of select="rating4"/></td>
                </xsl:when>
                <xsl:otherwise>
                    <td><xsl:value-of select="rating4"/></td>
                </xsl:otherwise>
                </xsl:choose>
        </tr>
        </xsl:for-each>
    </table>
    </body>
    </html>
</xsl:template>
</xsl:stylesheet>
