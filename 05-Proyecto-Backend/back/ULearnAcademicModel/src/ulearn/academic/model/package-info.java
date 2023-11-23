@XmlJavaTypeAdapters({
    @XmlJavaTypeAdapter(value=LocalTimeAdapter.class)
})
package ulearn.academic.model;

import javax.xml.bind.annotation.adapters.XmlJavaTypeAdapter;
import javax.xml.bind.annotation.adapters.XmlJavaTypeAdapters;