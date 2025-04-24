// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiPincers : ComponentBase
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
		builder.AddAttribute(14, "d", "M329.78 20.344c-.842.003-1.687.005-2.53.03-25.534.782-51.27 11.864-71.53 32.064-40.637 40.512-45.503 99.74-12.75 162.156 7.468-7.77 17.948-12.625 29.5-12.625 1.63 0 3.228.123 4.81.31-7.385-12.674-12.023-25.99-13.467-39.686-2.692-25.526 5.91-51.74 25.906-75.594 17.222-20.545 42.123-29.6 66.967-32.313 15.924-1.738 31.875-.833 46.72 1.25-21.29-24.748-47.497-35.683-73.626-35.593zm127.94 89.75c2.057 14.84 2.9 30.782 1.06 46.687-2.86 24.738-12.102 49.482-32.686 66.626-23.92 19.92-50.076 28.506-75.563 25.813-12.917-1.366-25.496-5.572-37.53-12.25.288 1.948.438 3.942.438 5.968 0 11.155-4.536 21.308-11.844 28.718C363.07 302.49 421.276 296.65 461.28 256.78c23.21-23.127 34.594-52.96 31.97-81.81-2.11-23.183-13.242-45.94-35.53-64.876zM272.47 220.656c-12.417 0-22.283 9.866-22.283 22.28 0 12.417 9.866 22.283 22.282 22.283 12.414 0 22.28-9.867 22.28-22.283 0-12.415-9.866-22.28-22.28-22.28zm-39.72 12.25C161.344 259.196 83.694 294.76 19.094 348.03v82.376c67.566-58.922 143.974-114.322 208.72-145.25-31.175 64.465-87.04 140.404-146.158 207.688h78.72c52.763-63.457 90.673-139.32 118-209.375-1.93.28-3.903.436-5.907.436-22.517 0-40.97-18.452-40.97-40.97 0-3.46.43-6.812 1.25-10.03z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
