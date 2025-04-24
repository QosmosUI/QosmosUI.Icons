// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiNovu : ComponentBase
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
		builder.AddAttribute(15, "d", "M18.48 9.6193c0 .6452-.7834.9647-1.2347.5035L8.0067.6804C9.256.2398 10.6 0 12 0c2.387 0 4.611.6969 6.48 1.8983zm3.36-4.4895v4.4895c0 3.6564-4.4392 5.4669-6.9962 2.8534L4.9087 2.3185C1.9323 4.5022 0 8.0255 0 12c0 2.5553.7987 4.924 2.16 6.8701v-4.4654c0-3.6564 4.4392-5.4669 6.9963-2.8534l9.9214 10.1403C22.0617 19.5086 24 15.9806 24 12c0-2.5553-.7987-4.924-2.16-6.8702ZM6.7546 13.9012l9.2212 9.4245C14.7316 23.7625 13.3934 24 12 24c-2.3869 0-4.611-.6968-6.48-1.8983v-7.697c0-.6453.7834-.9647 1.2346-.5035z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
