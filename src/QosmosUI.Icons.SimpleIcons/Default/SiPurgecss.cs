// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiPurgecss : ComponentBase
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
		builder.AddAttribute(15, "d", "M12 0C5.373 0 0 5.373 0 12a12 12 0 0 0 9.764 11.791c.048-1.003.052-2.55.047-9.967 0-5.484.003-9.995.013-10.023.028-.08 2.26-.042 2.678.047a4.903 4.903 0 0 1 3.078 2.08 4.834 4.834 0 0 1-.7 6.164c-.924.878-2.041 1.334-3.29 1.334-.225 0-.29.012-.305.068-.01.043-.02 2.418-.014 5.287v5.196A12 12 0 0 0 12 24c6.627 0 12-5.373 12-12S18.627 0 12 0zm-.691 4.31c-.013.004-.017.023-.02.063-.018.245-.023 8.358-.004 8.39.01.02.075-.014.145-.07 2.673-1.952 3.467-2.792 3.738-3.939.14-.746-.174-1.466-1.01-2.3-.699-.72-1.692-1.358-2.779-2.099-.038-.033-.058-.047-.07-.044z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
