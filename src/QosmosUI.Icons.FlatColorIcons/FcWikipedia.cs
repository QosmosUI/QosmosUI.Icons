// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons;

public class FcWikipedia : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "48px";

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
    public string ViewBox { get; set; } = "0 0 48 48";

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
		builder.AddAttribute(14, "fill", "#CFD8DC");
		builder.AddAttribute(15, "d", "M6,10c0-2.209,1.791-4,4-4h28c2.209,0,4,1.791,4,4v28c0,2.209-1.791,4-4,4H10c-2.209,0-4-1.791-4-4V10z");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "fill", "#37474F");
		builder.AddAttribute(18, "d", "M39,17.271c0,0.191-0.148,0.349-0.334,0.349h-1.799l-8.164,18.179c-0.052,0.12-0.17,0.2-0.297,0.202h-0.004	c-0.127,0-0.242-0.074-0.298-0.193l-3.874-8.039l-4.18,8.049c-0.06,0.116-0.167,0.181-0.303,0.184	c-0.125-0.004-0.239-0.082-0.292-0.199l-8.252-18.182h-1.87C9.149,17.619,9,17.462,9,17.271V16.35C9,16.155,9.149,16,9.333,16h6.657	c0.184,0,0.333,0.155,0.333,0.35v0.921c0,0.191-0.149,0.349-0.333,0.349h-1.433l5.696,13.748l2.964-5.793l-3.757-7.953h-0.904	c-0.184,0-0.333-0.157-0.333-0.35V16.35c0-0.191,0.149-0.348,0.333-0.348h4.924c0.184,0,0.333,0.156,0.333,0.348v0.922	c0,0.192-0.149,0.35-0.333,0.35h-0.867l2.162,4.948l2.572-4.948H25.77c-0.187,0-0.334-0.157-0.334-0.35V16.35	c0-0.191,0.147-0.348,0.334-0.348h4.784c0.187,0,0.333,0.156,0.333,0.348v0.922c0,0.192-0.146,0.35-0.333,0.35h-1.05l-3.757,7.141	l3.063,6.584l5.905-13.725h-1.872c-0.184,0-0.334-0.157-0.334-0.35V16.35c0-0.191,0.15-0.348,0.334-0.348h5.822	c0.186,0,0.334,0.156,0.334,0.348V17.271z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
