// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiJsfiddle : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M13.9 3.602c-2.749 0-5.103 1.544-6.35 3.779-.536-.317-1.139-.54-1.806-.54-1.981 0-3.6 1.606-3.6 3.579 0 .263.063.513.118.762C.912 12.09 0 13.602 0 15.344c0 2.763 2.241 5.012 5.008 5.054a.421.421 0 00.008 0h14c2.746.017 4.984-2.206 4.984-4.937 0-1.946-1.153-3.602-2.799-4.41.003-.062.01-.115.01-.184 0-4.008-3.28-7.265-7.31-7.265zm0 .843c3.58 0 6.47 2.872 6.47 6.422 0 .115-.012.242-.02.387a.421.421 0 00.26.414 4.104 4.104 0 012.546 3.793 4.094 4.094 0 01-4.135 4.096.421.421 0 00-.003 0H5.02C2.702 19.52.844 17.653.844 15.344c0-1.545.834-2.883 2.08-3.62a.421.421 0 00.187-.49 2.701 2.701 0 01-.125-.814 2.741 2.741 0 012.758-2.736 2.75 2.75 0 011.686.576.421.421 0 00.636-.15A6.462 6.462 0 0113.9 4.444zm-5.33 6.877c-1.586 0-2.91 1.213-2.91 2.737 0 1.523 1.324 2.736 2.91 2.736 1.411 0 2.182-.931 2.496-1.266a.421.421 0 10-.613-.578c-.378.402-.819 1.002-1.883 1.002-1.162 0-2.068-.86-2.068-1.894 0-1.035.906-1.895 2.068-1.895.533 0 1.105.297 1.686.77.372.303.737.668 1.098 1.043a.421.421 0 00.085.123c.533.552 1.122 1.205 1.774 1.736.652.531 1.386.959 2.217.959 1.586 0 2.91-1.213 2.91-2.736 0-1.524-1.324-2.737-2.91-2.737-1.411 0-2.182.931-2.496 1.266a.421.421 0 10.613.578c.378-.402.819-1.002 1.883-1.002 1.162 0 2.068.86 2.068 1.895 0 1.034-.906 1.894-2.068 1.894-.533 0-1.105-.297-1.686-.77-.372-.303-.737-.67-1.098-1.044a.421.421 0 00-.085-.121c-.533-.552-1.122-1.208-1.774-1.739-.652-.53-1.386-.957-2.217-.957Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
