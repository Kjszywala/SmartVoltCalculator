document.addEventListener('alpine:init', () => {
    Alpine.data('calculator', () => ({
        label: 'label calc',
        async init() {
            console.log('Init in calculator');
        },
    }))
})
