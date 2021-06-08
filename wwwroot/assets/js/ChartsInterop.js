function LineBarChart(Id,label, serie) {
    new Chartist.Bar(Id, {
        labels: label,
        series: serie
    }, {
        fullWidth: true,
        chartPadding: {
            right: 40
            },
            plugins: [
                Chartist.plugins.tooltip()
            ]
    });    
}