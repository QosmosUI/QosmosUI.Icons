// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiLava : ComponentBase
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
		builder.AddAttribute(14, "d", "M257.188 45.875A44.867 44.867 0 0 0 211.28 91 44.867 44.867 0 1 0 301 91a44.867 44.867 0 0 0-43.813-45.125zM91.905 90.625A44.867 44.867 0 0 0 46 135.72a44.867 44.867 0 1 0 89.72 0 44.867 44.867 0 0 0-43.814-45.095zm330.281 0a44.867 44.867 0 0 0-45.906 45.094 44.867 44.867 0 1 0 89.72 0 44.867 44.867 0 0 0-43.813-45.095zM256.845 210.97A29.866 29.866 0 0 0 226.28 241a29.866 29.866 0 1 0 59.72 0 29.866 29.866 0 0 0-29.156-30.03zm-135 30A29.866 29.866 0 0 0 91.28 271a29.866 29.866 0 1 0 59.72 0 29.866 29.866 0 0 0-29.156-30.03zm270 0A29.866 29.866 0 0 0 361.28 271a29.866 29.866 0 1 0 59.72 0 29.866 29.866 0 0 0-29.156-30.03zm-135.5 89.81A15 15 0 0 0 241 345.876a15 15 0 1 0 30 0 15 15 0 0 0-14.656-15.094zm-120 15A15 15 0 0 0 121 360.876a15 15 0 1 0 30 0 15 15 0 0 0-14.656-15.094zm240 0A15 15 0 0 0 361 360.876a15 15 0 1 0 30 0 15 15 0 0 0-14.656-15.094zM76 375.876c-15 0-30 30-30 30-30 0-30 0-30 30v30h480v-30c0-30 0-30-30-30 0 0-15-30-30-30-30 0-30 45-60 45s-30-45-60-45-30 45-60 45-30-45-60-45-30 45-60 45-30-45-60-45z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
