document.addEventListener('DOMContentLoaded', () => {

    const militaryStatusInput = document.getElementById('askerlikDurumu');
    const workTypeInput = document.getElementById('calismaSekli');
    const workPreferenceInput = document.getElementById('calismaTercihi');
    const licenseInput = document.getElementById('ehliyet');
    const addOptionalButton = document.getElementById('addOptional');
    const optionalList = document.getElementById('optionalList');

    addOptionalButton.addEventListener('click', () => {
        const militaryStatus = militaryStatusInput.value.trim();
        const workType = workTypeInput.value.trim();
        const workPreference = workPreferenceInput.value.trim();
        const license = licenseInput.value.trim();

        if (militaryStatus && workType && workPreference && license) {
            const li = document.createElement('li');
            li.className = 'optional-item';

            const span = document.createElement('span');
            span.textContent = `Askerlik Durumu: ${militaryStatus}, Çalışma Şekli: ${workType}, Çalışma Tercihi: ${workPreference}, Ehliyet: ${license}`;
            li.appendChild(span);

            const removeButton = document.createElement('button');
            removeButton.textContent = '×';
            removeButton.addEventListener('click', () => {
                optionalList.removeChild(li);
            });
            li.appendChild(removeButton);

            optionalList.appendChild(li);

            militaryStatusInput.value = '';
            workTypeInput.value = '';
            workPreferenceInput.value = '';
            licenseInput.value = '';
        }
    });

    const competencyInput = document.getElementById('competency');
    const subcategoryInput = document.getElementById('subcategory');
    const subLevelInput = document.getElementById('sub-level'); // Updated ID
    const levelInput = document.getElementById('level');
    const addSkillButton = document.getElementById('addSkill');
    const skillList = document.getElementById('skillList');

    addSkillButton.addEventListener('click', () => {
        const competency = competencyInput.value.trim();
        const subcategory = subcategoryInput.value.trim();
        const subLevel = subLevelInput.value.trim(); // Updated variable
        const level = levelInput.value.trim();

        if (competency && subcategory && subLevel && level) {
            const li = document.createElement('li');
            li.className = 'skill-item';

            const span = document.createElement('span');
            span.textContent = `Yetkinlik: ${competency}, Alt kategori: ${subcategory}, Seviye: ${level}, Alt Katagori: ${subLevel}`; // Updated text
            li.appendChild(span);

            const removeButton = document.createElement('button');
            removeButton.textContent = '×';
            removeButton.addEventListener('click', () => {
                skillList.removeChild(li);
            });
            li.appendChild(removeButton);

            skillList.appendChild(li);

            competencyInput.value = '';
            subcategoryInput.value = '';
            subLevelInput.value = ''; // Updated reset
            levelInput.value = '';
        }
    });

    const educationStatusInput = document.getElementById('educationStatus');
    const gradeSystemInput = document.getElementById('gradeSystem');
    const diplomaGradeInput = document.getElementById('diplomaGrade');
    const universityInput = document.getElementById('university');
    const cityInput = document.getElementById('city');
    const languageInput = document.getElementById('language');
    const departmentInput = document.getElementById('department');
    const addEducationButton = document.getElementById('addEducation');
    const educationList = document.getElementById('educationList');

    addEducationButton.addEventListener('click', () => {
        const educationStatus = educationStatusInput.value.trim();
        const gradeSystem = gradeSystemInput.value.trim();
        const diplomaGrade = diplomaGradeInput.value.trim();
        const university = universityInput.value.trim();
        const city = cityInput.value.trim();
        const language = languageInput.value.trim();
        const department = departmentInput.value.trim();

        if (educationStatus && gradeSystem && diplomaGrade && university && city && language && department) {
            const li = document.createElement('li');
            li.className = 'education-item';

            const div = document.createElement('div');

            const educationStatusSpan = document.createElement('span');
            educationStatusSpan.textContent = `EĞİTİM DURUMU: ${educationStatus}`;
            div.appendChild(educationStatusSpan);
            div.appendChild(document.createElement('br'));

            const gradeSystemSpan = document.createElement('span');
            gradeSystemSpan.textContent = `NOT SİSTEMİ: ${gradeSystem}`;
            div.appendChild(gradeSystemSpan);
            div.appendChild(document.createElement('br'));

            const diplomaGradeSpan = document.createElement('span');
            diplomaGradeSpan.textContent = `DİPLOMA NOTU: ${diplomaGrade}`;
            div.appendChild(diplomaGradeSpan);
            div.appendChild(document.createElement('br'));

            const universitySpan = document.createElement('span');
            universitySpan.textContent = `Universite: ${university}`;
            div.appendChild(universitySpan);
            div.appendChild(document.createElement('br'));

            const citySpan = document.createElement('span');
            citySpan.textContent = `SEHİR: ${city}`;
            div.appendChild(citySpan);
            div.appendChild(document.createElement('br'));

            const languageSpan = document.createElement('span');
            languageSpan.textContent = `ÖĞRETİM DİLİ: ${language}`;
            div.appendChild(languageSpan);
            div.appendChild(document.createElement('br'));

            const departmentSpan = document.createElement('span');
            departmentSpan.textContent = `BÖLÜM: ${department}`;
            div.appendChild(departmentSpan);

            li.appendChild(div);

            const removeButton = document.createElement('button');
            removeButton.textContent = '×';
            removeButton.addEventListener('click', () => {
                educationList.removeChild(li);
            });
            li.appendChild(removeButton);

            educationList.appendChild(li);

            educationStatusInput.value = '';
            gradeSystemInput.value = '';
            diplomaGradeInput.value = '';
            universityInput.value = '';
            cityInput.value = '';
            languageInput.value = '';
            departmentInput.value = '';
        }
    });
});
