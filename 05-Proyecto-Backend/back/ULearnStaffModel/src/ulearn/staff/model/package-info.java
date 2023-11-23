@XmlJavaTypeAdapters({
    @XmlJavaTypeAdapter(value=LocalTimeAdapter.class)
})
package ulearn.staff.model;

import javax.xml.bind.annotation.adapters.XmlJavaTypeAdapter;
import javax.xml.bind.annotation.adapters.XmlJavaTypeAdapters;