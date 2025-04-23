// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiReactor : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M256 41.875c-60.562 0-60.547 15.14-75.688 60.563l-30.28 90.843 41.624 41.626c16.44-16.44 39.26-26.47 64.344-26.47 25.085 0 47.904 10.03 64.344 26.47l41.625-41.625-30.283-90.843c-15.14-45.42-15.125-60.562-75.687-60.562zm0 196.844c-33.447 0-60.563 27.083-60.563 60.53s27.116 60.563 60.563 60.563 60.563-27.116 60.563-60.563-27.116-60.53-60.563-60.53zm-144.78 21.75l-63.532 71.655C15.92 367.947 2.813 375.52 33.093 427.97c30.28 52.447 43.406 44.88 90.312 35.28l93.813-19.22 15.218-56.874c-22.457-6.017-42.552-20.744-55.094-42.47-12.544-21.723-15.267-46.51-9.25-68.967l-56.875-15.25zm289.56 0l-56.874 15.25c6.017 22.455 3.293 47.243-9.25 68.967-12.542 21.725-32.637 36.452-55.094 42.47l15.22 56.874 93.812 19.22c46.906 9.6 60.03 17.167 90.312-35.28 30.28-52.45 17.173-60.023-14.594-95.845l-63.53-71.656z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
