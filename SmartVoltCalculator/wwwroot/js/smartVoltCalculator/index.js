document.addEventListener('alpine:init', () => {
    Alpine.data('calculator', () => ({
        monthlyElectricityUsage: 280,
        priceKWH: 28.6,
        sum: 0,
        estimatedSolarSystemSize: 0,
        averageDailySunlightHours: 0,
        async init() {
            console.log('Init in calculator');
            this.sum = this.monthlyElectricityUsage * (this.priceKWH / 100);
        },
    }))
})
