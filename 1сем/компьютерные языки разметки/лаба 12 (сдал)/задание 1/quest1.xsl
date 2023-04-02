<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="body">
    <html>
    <head>
        <title>My first template rule</title>
    </head>
    <body>
    <h2>Собаки</h2>
    <table border="1">
        <tr bgcolor="lightblue">
            <th>Имя</th>
            <th>Парода</th>
            <th>Вес</th>
            <th>Страна происхождения</th>
        </tr>
        <xsl:for-each select="people">
        <xsl:sort select="name"/>
            <tr>
                <td><xsl:value-of select="name"/></td>
                <td><xsl:value-of select="surname"/></td>
                <td><xsl:value-of select="type"/></td>
                <td><xsl:value-of select="country"/></td>
            </tr>
        </xsl:for-each>
    </table>
    </body>
    </html>
</xsl:template>
</xsl:stylesheet>
