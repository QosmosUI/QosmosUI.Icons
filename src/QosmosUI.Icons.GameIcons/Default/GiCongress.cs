// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiCongress : ComponentBase
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
		builder.AddAttribute(14, "d", "M247.002 32v47.725a56.476 56.476 0 0 1 17.996 0V32h-17.996zM256 96.998c-11.5 0-23.002 5.001-23.002 15.002v10.1c7.37-2 15.05-3.098 23.002-3.098 7.953 0 15.632 1.098 23.002 3.098V112c0-10-11.502-15.002-23.002-15.002zm0 40c-28.25 0-53.982 17.938-72.867 42.488-16.345 21.249-26.934 47.277-29.496 67.516h204.726c-2.562-20.239-13.15-46.267-29.496-67.516-18.885-24.55-44.617-42.488-72.867-42.488zm-80 78.004h32v17.996h-32v-17.996zm64 0h32v17.996h-32v-17.996zm64 0h32v17.996h-32v-17.996zm-170.29 49.996l-7.53 16.004h259.64l-7.53-16.004H133.71zm1.292 34v28.004h17.996v-28.004h-17.996zm56 0v28.004h17.996v-28.004h-17.996zm56 0v28.004h17.996v-28.004h-17.996zm56 0v28.004h17.996v-28.004h-17.996zm56 0v28.004h17.996v-28.004h-17.996zm-270.004 46v16.004h334.004v-16.004H88.998zm14.004 34v60.004h17.996v-60.004h-17.996zm48 0v60.004h17.996v-60.004h-17.996zm48 0v60.004h17.996v-60.004h-17.996zm48 0v60.004h17.996v-60.004h-17.996zm48 0v60.004h17.996v-60.004h-17.996zm48 0v60.004h17.996v-60.004h-17.996zm48 0v60.004h17.996v-60.004h-17.996zm-350.004 78v30.004h430.004v-30.004H40.998z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
