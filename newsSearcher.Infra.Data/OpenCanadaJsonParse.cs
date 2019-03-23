using System;
using System.Collections.Generic;
using System.Text;

namespace newsSearcher.Infra.Data
{

    public class OpenCanadaJsonParse
    {
        public string help { get; set; }
        public bool success { get; set; }
        public Result result { get; set; }
    }

    public class SearchFacets
    {
    }

    public class Facets
    {
    }

    public class NotesTranslated
    {
        public string fr { get; set; }
        public string en { get; set; }
    }

    public class OrgSection
    {
        public string fr { get; set; }
        public string en { get; set; }
    }

    public class Contributor
    {
        public string fr { get; set; }
        public string en { get; set; }
    }

    public class Keywords
    {
        public List<string> fr { get; set; }
        public List<string> en { get; set; }
    }

    public class DataSeriesIssueIdentification
    {
        public string fr { get; set; }
        public string en { get; set; }
    }

    public class PositionName
    {
    }

    public class TitleTranslated
    {
        public string fr { get; set; }
        public string en { get; set; }
    }

    public class NameTranslated
    {
        public string fr { get; set; }
        public string en { get; set; }
    }

    public class Resource
    {
        public object cache_last_updated { get; set; }
        public string unique_identifier { get; set; }
        public string package_id { get; set; }
        public bool datastore_active { get; set; }
        public string character_set { get; set; }
        public string related_type { get; set; }
        public string state { get; set; }
        public string id { get; set; }
        public string related_relationship { get; set; }
        public NameTranslated name_translated { get; set; }
        public string hash { get; set; }
        public string description { get; set; }
        public string format { get; set; }
        public string date_published { get; set; }
        public object mimetype_inner { get; set; }
        public string url_type { get; set; }
        public object mimetype { get; set; }
        public object cache_url { get; set; }
        public string name { get; set; }
        public List<string> language { get; set; }
        public DateTime created { get; set; }
        public string url { get; set; }
        public object last_modified { get; set; }
        public string resource_type { get; set; }
        public int position { get; set; }
        public string revision_id { get; set; }
        public List<object> data_quality { get; set; }
    }

    public class MetadataContact
    {
    }

    public class OrgTitleAtPublication
    {
        public string fr { get; set; }
        public string en { get; set; }
    }

    public class DataSeriesName
    {
        public string fr { get; set; }
        public string en { get; set; }
    }

    public class Organization
    {
        public string description { get; set; }
        public DateTime created { get; set; }
        public string title { get; set; }
        public string name { get; set; }
        public bool is_organization { get; set; }
        public string state { get; set; }
        public string image_url { get; set; }
        public string revision_id { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string approval_status { get; set; }
    }

    public class ProgramPageUrl
    {
        public string fr { get; set; }
        public string en { get; set; }
    }

    public class AdditionalNotes
    {
        public string fr { get; set; }
        public string en { get; set; }
    }

    public class SeriesPublicationDates
    {
        public string fr { get; set; }
        public string en { get; set; }
    }

    public class Result2
    {
        public NotesTranslated notes_translated { get; set; }
        public string imso_approval { get; set; }
        public object maintainer { get; set; }
        public string creator { get; set; }
        public List<object> association_type { get; set; }
        public OrgSection org_section { get; set; }
        public string jurisdiction { get; set; }
        public bool @private { get; set; }
        public string maintainer_email { get; set; }
        public int num_tags { get; set; }
        public Contributor contributor { get; set; }
        public string frequency { get; set; }
        public Keywords keywords { get; set; }
        public DataSeriesIssueIdentification data_series_issue_identification { get; set; }
        public string ready_to_publish { get; set; }
        public string id { get; set; }
        public DateTime metadata_created { get; set; }
        public List<string> subject { get; set; }
        public List<object> spatial_representation_type { get; set; }
        public DateTime metadata_modified { get; set; }
        public object author { get; set; }
        public string author_email { get; set; }
        public List<object> geographic_region { get; set; }
        public PositionName position_name { get; set; }
        public string portal_release_date { get; set; }
        public string digital_object_identifier { get; set; }
        public string state { get; set; }
        public object version { get; set; }
        public List<object> relationships_as_object { get; set; }
        public string creator_user_id { get; set; }
        public TitleTranslated title_translated { get; set; }
        public string type { get; set; }
        public List<Resource> resources { get; set; }
        public List<object> place_of_publication { get; set; }
        public MetadataContact metadata_contact { get; set; }
        public int num_resources { get; set; }
        public List<object> topic_category { get; set; }
        public List<object> tags { get; set; }
        public string spatial { get; set; }
        public string collection { get; set; }
        public OrgTitleAtPublication org_title_at_publication { get; set; }
        public string date_published { get; set; }
        public List<object> display_flags { get; set; }
        public List<object> groups { get; set; }
        public string license_id { get; set; }
        public DataSeriesName data_series_name { get; set; }
        public List<object> relationships_as_subject { get; set; }
        public string license_title { get; set; }
        public string restrictions { get; set; }
        public Organization organization { get; set; }
        public string name { get; set; }
        public bool isopen { get; set; }
        public string date_modified { get; set; }
        public string url { get; set; }
        public string notes { get; set; }
        public string owner_org { get; set; }
        public List<object> audience { get; set; }
        public string license_url { get; set; }
        public ProgramPageUrl program_page_url { get; set; }
        public string title { get; set; }
        public string revision_id { get; set; }
        public string issuance_frequency { get; set; }
        public string issn { get; set; }
        public string isbn { get; set; }
        public string edition { get; set; }
        public string pspc_identification_number { get; set; }
        public string issuance { get; set; }
        public AdditionalNotes additional_notes { get; set; }
        public string departmental_identification_number { get; set; }
        public string gc_catalogue_number { get; set; }
        public SeriesPublicationDates series_publication_dates { get; set; }
        public string time_period_coverage_start { get; set; }
        public string time_period_coverage_end { get; set; }
        public string presentation_form { get; set; }
    }

    public class PortalReleaseDate
    {
        public DateTime start { get; set; }
        public List<object> counts { get; set; }
        public DateTime end { get; set; }
        public string gap { get; set; }
    }

    public class FacetRanges
    {
        public PortalReleaseDate portal_release_date { get; set; }
    }

    public class Result
    {
        public int count { get; set; }
        public string sort { get; set; }
        public SearchFacets search_facets { get; set; }
        public Facets facets { get; set; }
        public List<Result2> results { get; set; }
        public FacetRanges facet_ranges { get; set; }
    }


}
