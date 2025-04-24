// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiBasicattentiontoken : ComponentBase
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
		builder.AddAttribute(15, "d", "m23.917 21.886.062-.124v-.042c0-.041.021-.083.021-.103v-.042c0-.041 0-.103-.02-.145l-.063-.124v-.021L12.54 2.135A.618.618 0 0 0 12 1.824c-.228 0-.415.124-.539.31L.083 21.265v.021l-.062.124C0 21.451 0 21.513 0 21.554v.042c0 .041 0 .083.02.103v.042c.021.041.021.083.063.124l.02.021c.021.041.042.083.084.104l.062.062c.02.02.041.041.062.041.02.021.062.021.083.042.02 0 .041.02.062.02.062.021.104.021.166.021h22.736c.062 0 .103 0 .165-.02.021 0 .042-.021.063-.021.041-.021.062-.021.103-.042.02-.02.042-.02.062-.041l.062-.062a.364.364 0 0 0 .083-.104h.021ZM12 11.316l3.627 5.845H8.373L12 11.316Zm-.622-1.347-4.56 7.357-4.455 2.55 9.015-15.15v5.243ZM7.42 18.425h9.14l4.456 2.55H2.964l4.456-2.55Zm9.761-1.099-4.56-7.357V4.725l9.016 15.15-4.456-2.549Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
