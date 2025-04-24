// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons.Default;

public class GrVimeo : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 24 24";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "fill-rule", "evenodd");
		builder.AddAttribute(15, "d", "M23.9883358,6.80210856 C23.8810843,9.13839127 22.2498115,12.336436 19.0937673,16.3969929 C15.8304716,20.6368022 13.069683,22.7570819 10.8121514,22.7570819 C9.41263176,22.7570819 8.22836518,21.4663138 7.26160165,18.8840277 C6.61584261,16.5162445 5.97083358,14.1484614 5.32432453,11.7806783 C4.60581447,9.19914212 3.8363037,7.90687403 3.01204216,7.90687403 C2.83203964,7.90687403 2.20428086,8.28487932 1.12801579,9.03713985 L0,7.58286949 C1.18426658,6.54260493 2.35203292,5.50234037 3.50179902,4.45982578 C5.08132113,3.09555668 6.26858775,2.37779663 7.0583488,2.30504561 C8.92587495,2.1257931 10.075641,3.40231097 10.5068971,6.13459922 C10.9734036,9.08289049 11.2966581,10.9166662 11.4774107,11.6344262 C12.0166682,14.0809605 12.6091765,15.3027276 13.2556856,15.3027276 C13.7574426,15.3027276 14.5127032,14.5092164 15.5184672,12.9214442 C16.5234813,11.335172 17.0619888,10.1284051 17.1339898,9.2981435 C17.2779919,7.92937434 16.7394843,7.24311474 15.5184672,7.24311474 C14.9439592,7.24311474 14.3514509,7.37511658 13.7424424,7.63612024 C14.9222089,3.77356617 17.1752404,1.89778991 20.501537,2.0042914 C22.9675715,2.07704242 24.1308378,3.6760648 23.9883358,6.80210856");
		builder.CloseElement();
		builder.CloseElement();
    }
}
